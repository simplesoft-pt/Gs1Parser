namespace SimpleSoft.Gs1Parser;

/// <summary>
/// Represents a GS1 parser.
/// </summary>
public class Gs1Parser : IGs1Parser
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

    /// <inheritdoc />
    public IGs1 Parse(string rawValue)
    {
        var gs1 = new Gs1(rawValue);
        var idx = 0;
        do
        {
            if (!TryGetExtractor(rawValue, idx, out var prefix, out var extractor))
                throw new FormatException($"Unknown GS1 prefix found on '{rawValue.Substring(idx)}'");

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
        Gs1ApplicationIdentifier FixedLength07OptionalSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 07, s, false);
        Gs1ApplicationIdentifier FixedLength13OptionalSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 13, s, false);
        Gs1ApplicationIdentifier FixedLength14OptionalSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 14, s, false);
        Gs1ApplicationIdentifier FixedLength18OptionalSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 18, s, false);

        Gs1ApplicationIdentifier FixedLength01RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 01, s, true);
        Gs1ApplicationIdentifier FixedLength02RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 02, s, true);
        Gs1ApplicationIdentifier FixedLength03RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 03, s, true);
        Gs1ApplicationIdentifier FixedLength04RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 04, s, true);
        Gs1ApplicationIdentifier FixedLength05RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 05, s, true);
        Gs1ApplicationIdentifier FixedLength06RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 06, s, true);
        Gs1ApplicationIdentifier FixedLength07RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 07, s, true);
        Gs1ApplicationIdentifier FixedLength10RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 10, s, true);
        Gs1ApplicationIdentifier FixedLength13RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 13, s, true);
        Gs1ApplicationIdentifier FixedLength14RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 14, s, true);
        Gs1ApplicationIdentifier FixedLength17RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 17, s, true);
        Gs1ApplicationIdentifier FixedLength18RequiredSeparator(string v, int idx, string p, char s) => ExtractFixedLength(v, idx, p, 18, s, true);

        Gs1ApplicationIdentifier VariableLength02(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 02, s);
        Gs1ApplicationIdentifier VariableLength03(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 03, s);
        Gs1ApplicationIdentifier VariableLength04(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 04, s);
        Gs1ApplicationIdentifier VariableLength06(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 06, s);
        Gs1ApplicationIdentifier VariableLength08(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 08, s);
        Gs1ApplicationIdentifier VariableLength10(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 10, s);
        Gs1ApplicationIdentifier VariableLength12(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 12, s);
        Gs1ApplicationIdentifier VariableLength15(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 15, s);
        Gs1ApplicationIdentifier VariableLength16(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 16, s);
        Gs1ApplicationIdentifier VariableLength19(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 19, s);
        Gs1ApplicationIdentifier VariableLength20(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 20, s);
        Gs1ApplicationIdentifier VariableLength25(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 25, s);
        Gs1ApplicationIdentifier VariableLength28(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 28, s);
        Gs1ApplicationIdentifier VariableLength30(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 30, s);
        Gs1ApplicationIdentifier VariableLength34(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 34, s);
        Gs1ApplicationIdentifier VariableLength35(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 35, s);
        Gs1ApplicationIdentifier VariableLength50(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 50, s);
        Gs1ApplicationIdentifier VariableLength70(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 70, s);
        Gs1ApplicationIdentifier VariableLength90(string v, int idx, string p, char s) => ExtractVariableLength(v, idx, p, 90, s);

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
            {"22", VariableLength20},
            {"235", VariableLength28},
            {"240", VariableLength30},
            {"241", VariableLength30},
            {"242", VariableLength06},
            {"243", VariableLength20},
            {"250", VariableLength20},
            {"251", VariableLength20},
            {"253", VariableLength30},
            {"254", VariableLength20},
            {"255", VariableLength25},

            {"30", VariableLength08},
            {"310", FixedLength07OptionalSeparator},
            {"311", FixedLength07OptionalSeparator},
            {"312", FixedLength07OptionalSeparator},
            {"313", FixedLength07OptionalSeparator},
            {"314", FixedLength07OptionalSeparator},
            {"315", FixedLength07OptionalSeparator},
            {"316", FixedLength07OptionalSeparator},
            {"320", FixedLength07OptionalSeparator},
            {"321", FixedLength07OptionalSeparator},
            {"322", FixedLength07OptionalSeparator},
            {"323", FixedLength07OptionalSeparator},
            {"324", FixedLength07OptionalSeparator},
            {"325", FixedLength07OptionalSeparator},
            {"326", FixedLength07OptionalSeparator},
            {"327", FixedLength07OptionalSeparator},
            {"328", FixedLength07OptionalSeparator},
            {"329", FixedLength07OptionalSeparator},
            {"330", FixedLength07OptionalSeparator},
            {"331", FixedLength07OptionalSeparator},
            {"332", FixedLength07OptionalSeparator},
            {"333", FixedLength07OptionalSeparator},
            {"334", FixedLength07OptionalSeparator},
            {"335", FixedLength07OptionalSeparator},
            {"336", FixedLength07OptionalSeparator},
            {"337", FixedLength07OptionalSeparator},
            {"340", FixedLength07OptionalSeparator},
            {"341", FixedLength07OptionalSeparator},
            {"342", FixedLength07OptionalSeparator},
            {"343", FixedLength07OptionalSeparator},
            {"344", FixedLength07OptionalSeparator},
            {"345", FixedLength07OptionalSeparator},
            {"346", FixedLength07OptionalSeparator},
            {"347", FixedLength07OptionalSeparator},
            {"348", FixedLength07OptionalSeparator},
            {"349", FixedLength07OptionalSeparator},
            {"350", FixedLength07OptionalSeparator},
            {"351", FixedLength07OptionalSeparator},
            {"352", FixedLength07OptionalSeparator},
            {"353", FixedLength07OptionalSeparator},
            {"354", FixedLength07OptionalSeparator},
            {"355", FixedLength07OptionalSeparator},
            {"356", FixedLength07OptionalSeparator},
            {"357", FixedLength07OptionalSeparator},
            {"360", FixedLength07OptionalSeparator},
            {"361", FixedLength07OptionalSeparator},
            {"362", FixedLength07OptionalSeparator},
            {"363", FixedLength07OptionalSeparator},
            {"364", FixedLength07OptionalSeparator},
            {"365", FixedLength07OptionalSeparator},
            {"366", FixedLength07OptionalSeparator},
            {"367", FixedLength07OptionalSeparator},
            {"368", FixedLength07OptionalSeparator},
            {"369", FixedLength07OptionalSeparator},
            {"37", VariableLength08},
            {"390", VariableLength16},
            {"391", VariableLength19},
            {"392", VariableLength16},
            {"393", VariableLength19},
            {"394", FixedLength05RequiredSeparator},
            {"395", FixedLength07RequiredSeparator},

            {"400", VariableLength30},
            {"401", VariableLength30},
            {"402", FixedLength17RequiredSeparator},
            {"403", VariableLength30},
            {"410", FixedLength13OptionalSeparator},
            {"411", FixedLength13OptionalSeparator},
            {"412", FixedLength13OptionalSeparator},
            {"413", FixedLength13OptionalSeparator},
            {"414", FixedLength13OptionalSeparator},
            {"415", FixedLength13OptionalSeparator},
            {"416", FixedLength13OptionalSeparator},
            {"417", FixedLength13OptionalSeparator},
            {"420", VariableLength20},
            {"421", VariableLength12},
            {"422", FixedLength03RequiredSeparator},
            {"423", VariableLength15},
            {"424", FixedLength03RequiredSeparator},
            {"425", VariableLength15},
            {"426", FixedLength03RequiredSeparator},
            {"427", VariableLength15},
            {"4300", VariableLength35},
            {"4301", VariableLength35},
            {"4302", VariableLength70},
            {"4303", VariableLength70},
            {"4304", VariableLength70},
            {"4305", VariableLength70},
            {"4306", VariableLength70},
            {"4307", FixedLength02RequiredSeparator},
            {"4308", VariableLength30},
            {"4310", VariableLength35},
            {"4311", VariableLength35},
            {"4312", VariableLength70},
            {"4313", VariableLength70},
            {"4314", VariableLength70},
            {"4315", VariableLength70},
            {"4316", VariableLength70},
            {"4317", FixedLength02RequiredSeparator},
            {"4318", VariableLength20},
            {"4319", VariableLength30},
            {"4320", VariableLength35},
            {"4321", FixedLength01RequiredSeparator},
            {"4322", FixedLength01RequiredSeparator},
            {"4323", FixedLength01RequiredSeparator},
            {"4324", FixedLength10RequiredSeparator},
            {"4325", FixedLength10RequiredSeparator},
            {"4326", FixedLength06RequiredSeparator},

            {"7001", FixedLength13RequiredSeparator},
            {"7002", VariableLength30},
            {"7003", FixedLength10RequiredSeparator},
            {"7004", VariableLength04},
            {"7005", VariableLength12},
            {"7006", FixedLength06RequiredSeparator},
            {"7007", VariableLength12},
            {"7008", VariableLength03},
            {"7009", VariableLength10},
            {"7010", VariableLength02},
            {"7020", VariableLength20},
            {"7021", VariableLength20},
            {"7022", VariableLength20},
            {"7023", VariableLength30},
            {"7030", VariableLength30},
            {"7031", VariableLength30},
            {"7032", VariableLength30},
            {"7033", VariableLength30},
            {"7034", VariableLength30},
            {"7035", VariableLength30},
            {"7036", VariableLength30},
            {"7037", VariableLength30},
            {"7038", VariableLength30},
            {"7039", VariableLength30},
            {"7040", FixedLength04RequiredSeparator},
            {"710", VariableLength20},
            {"711", VariableLength20},
            {"712", VariableLength20},
            {"713", VariableLength20},
            {"714", VariableLength20},
            {"715", VariableLength20},
            {"7230", VariableLength30},
            {"7231", VariableLength30},
            {"7232", VariableLength30},
            {"7233", VariableLength30},
            {"7234", VariableLength30},
            {"7235", VariableLength30},
            {"7236", VariableLength30},
            {"7237", VariableLength30},
            {"7238", VariableLength30},
            {"7239", VariableLength30},
            {"7240", VariableLength20},

            {"8001", FixedLength14RequiredSeparator},
            {"8002", VariableLength20},
            {"8003", VariableLength30},
            {"8004", VariableLength30},
            {"8005", FixedLength06RequiredSeparator},
            {"8006", FixedLength18RequiredSeparator},
            {"8007", VariableLength34},
            {"8008", VariableLength12},
            {"8009", VariableLength50},
            {"8010", VariableLength30},
            {"8011", VariableLength12},
            {"8012", VariableLength20},
            {"8013", VariableLength25},
            {"8017", FixedLength18RequiredSeparator},
            {"8018", FixedLength18RequiredSeparator},
            {"8019", VariableLength10},
            {"8020", VariableLength25},
            {"8026", FixedLength18RequiredSeparator},
            {"8110", VariableLength70},
            {"8111", FixedLength04RequiredSeparator},
            {"8112", VariableLength70},
            {"8200", VariableLength70},

            {"90", VariableLength30},
            {"91", VariableLength90},
            {"92", VariableLength90},
            {"93", VariableLength90},
            {"94", VariableLength90},
            {"95", VariableLength90},
            {"96", VariableLength90},
            {"97", VariableLength90},
            {"98", VariableLength90},
            {"99", VariableLength90},
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
            throw new FormatException(
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
                throw new FormatException(
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
            throw new FormatException(
                $"GS1 application identifier '{prefix}' separator exceeds maximum length on '{value.Substring(startIndex)}'"
            );
        }

        var separatorLength = 1;
        if (separatorIndex == -1)
        {
            if (value.Length > indexedMaxLength)
            {
                throw new FormatException(
                    $"GS1 application identifier '{prefix}' required separator is missing from '{value.Substring(startIndex)}'"
                );
            }

            separatorLength = 0;
            separatorIndex = value.Length;
        }

        var length = separatorIndex - dataContentStartIndex;

        if (length == 0)
        {
            throw new FormatException(
                $"GS1 application identifier '{prefix}' doesn't have minimum length of 1 from '{value.Substring(startIndex)}'"
            );
        }

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
            throw new FormatException(
                $"GS1 application identifier '{prefix}' not found on '{value.Substring(startIndex)}'"
            );
        }
    }
}
