namespace SimpleSoft.Gs1Parser;

/// <summary>
/// Represents a GS1 parser.
/// </summary>
public class Gs1Parser
{
    private readonly Gs1ParserOptions _options;

    /// <summary>
    /// Creates a new instance using <see cref="Gs1ParserOptions.Default"/> options.
    /// </summary>
    public Gs1Parser() : this(Gs1ParserOptions.Default)
    {

    }

    /// <summary>
    /// Creates a new instance.
    /// </summary>
    /// <param name="options">The parser options</param>
    /// <exception cref="ArgumentNullException"></exception>
    public Gs1Parser(Gs1ParserOptions options)
    {
        options.NotNull(nameof(options));

        _options = options;
    }

    /// <summary>
    /// Parses a given GS1 string retuning a collection of application identifiers
    /// indexed by their prefix.
    /// </summary>
    /// <param name="rawValue">The GS1 string to parse</param>
    /// <returns>The collection of application identifiers</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public IGs1 Parse(string rawValue)
    {
        var gs1 = new Gs1(rawValue);
        var idx = 0;
        do
        {
            if (!TryGetExtractor(rawValue, idx, out var prefix, out var extractor))
                throw new InvalidOperationException($"Unknown GS1 prefix found on '{rawValue.Substring(idx)}'");

            var ai = extractor(rawValue, idx, prefix, _options.Separator);

            gs1[ai.Prefix] = ai;
            idx += ai.RawValue.Length;
        } while (idx < rawValue.Length);

        return gs1;
    }

    private bool TryGetExtractor(string value, int startIndex, out string prefix, out Gs1ApplicationIdentifierExtractor extractor)
    {
        if (value.Length >= startIndex + 2)
        {
            prefix = value.Substring(startIndex, 2);
            if(TryGetExtractor(prefix, out extractor))
                return true;

            if (value.Length >= startIndex + 3)
            {
                prefix = value.Substring(startIndex, 3);
                if (TryGetExtractor(prefix, out extractor))
                    return true;

                if (value.Length >= startIndex + 4)
                {
                    prefix = value.Substring(startIndex, 4);
                    if (TryGetExtractor(prefix, out extractor))
                        return true;
                }
            }
        }

        prefix = null;
        extractor = null;
        return false;
    }

    private bool TryGetExtractor(string prefix, out Gs1ApplicationIdentifierExtractor extractor)
    {
        if (_options.CustomExtractors?.Count > 0 && _options.CustomExtractors.TryGetValue(prefix, out extractor))
            return true;

        return StandardExtractors.TryGetValue(prefix, out extractor);
    }

    private static readonly Dictionary<string, Gs1ApplicationIdentifierExtractor> StandardExtractors;

    static Gs1Parser()
    {
        Gs1ApplicationIdentifier FixedLength02OptionalSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 02, s, false);
        Gs1ApplicationIdentifier FixedLength06OptionalSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 06, s, false);
        Gs1ApplicationIdentifier FixedLength14OptionalSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 14, s, false);
        Gs1ApplicationIdentifier FixedLength18OptionalSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 18, s, false);

        Gs1ApplicationIdentifier VariableLength20(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 20, s);

        StandardExtractors = new Dictionary<string, Gs1ApplicationIdentifierExtractor>
        {
            {"00", FixedLength18OptionalSeparator},
            {"01", FixedLength14OptionalSeparator},
            {"02", FixedLength14OptionalSeparator},
            {"10", VariableLength20},
            {"11", FixedLength06OptionalSeparator},
            {"12", FixedLength06OptionalSeparator},
            {"13", FixedLength06OptionalSeparator},
            {"15", FixedLength06OptionalSeparator},
            {"16", FixedLength06OptionalSeparator},
            {"17", FixedLength06OptionalSeparator},
            {"20", FixedLength02OptionalSeparator},
            {"21", VariableLength20},

            {"710", VariableLength20},
            {"711", VariableLength20},
            {"712", VariableLength20},
            {"713", VariableLength20},
            {"714", VariableLength20},
            {"715", VariableLength20},
        };
    }

    /// <summary>
    /// Default GS1 parser using default options.
    /// </summary>
    public static readonly Gs1Parser Default = new();

    private static Gs1ApplicationIdentifier ExtractFixedLength(
        string value,
        int startIndex,
        string prefix,
        int length,
        char separator,
        bool isSeparatorRequired
    )
    {
        EnsureStartsWithPrefix(value, startIndex, prefix);

        var dataContentStartIndex = startIndex + prefix.Length;
        if (value.Length < dataContentStartIndex + length)
        {
            throw new InvalidOperationException(
                $"GS1 application identifier '{prefix}' doesn't have the required length on '{value.Substring(startIndex)}'"
            );
        }

        var separatorLength = 0;
        if (value.Length > dataContentStartIndex + length)
        {
            if (value[dataContentStartIndex + length] == separator)
                separatorLength = 1;
            else if (isSeparatorRequired)
            {
                throw new InvalidOperationException(
                    $"GS1 application identifier '{prefix}' required separator is missing from '{value.Substring(startIndex)}'"
                );
            }
        }

        var rawValue = value.Substring(startIndex, prefix.Length + length + separatorLength);
        var dataContent = value.Substring(dataContentStartIndex, length);

        return new Gs1ApplicationIdentifier(
            rawValue,
            prefix,
            dataContent
        );
    }

    private static Gs1ApplicationIdentifier ExtractVariableLength(
        string value,
        int startIndex,
        string prefix,
        int maxLength,
        char separator
    )
    {
        EnsureStartsWithPrefix(value, startIndex, prefix);

        var dataContentStartIndex = startIndex + prefix.Length;
        var indexedMaxLength = dataContentStartIndex + maxLength;

        var separatorIndex = value.IndexOf(separator, startIndex);
        if (separatorIndex > indexedMaxLength)
        {
            throw new InvalidOperationException(
                $"GS1 application identifier '{prefix}' separator exceeds maximum length on '{value.Substring(startIndex)}'"
            );
        }

        var separatorLength = 1;
        if (separatorIndex == -1)
        {
            if (value.Length > indexedMaxLength)
            {
                throw new InvalidOperationException(
                    $"GS1 application identifier '{prefix}' required separator is missing from '{value.Substring(startIndex)}'"
                );
            }

            separatorLength = 0;
            separatorIndex = value.Length;
        }

        var length = separatorIndex - dataContentStartIndex;

        var rawValue = value.Substring(startIndex, prefix.Length + length + separatorLength);
        var dataContent = value.Substring(dataContentStartIndex, length);

        return new Gs1ApplicationIdentifier(
            rawValue,
            prefix,
            dataContent
        );
    }

    private static void EnsureStartsWithPrefix(
        string value,
        int startIndex,
        string prefix
    )
    {
        if (value.IndexOf(prefix, startIndex, StringComparison.OrdinalIgnoreCase) != startIndex)
        {
            throw new InvalidOperationException(
                $"GS1 application identifier '{prefix}' not found on '{value.Substring(startIndex)}'"
            );
        }
    }
}