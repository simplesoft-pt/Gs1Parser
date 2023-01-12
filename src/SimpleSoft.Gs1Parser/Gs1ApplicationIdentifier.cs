namespace SimpleSoft.Gs1Parser;

/// <summary>
/// Represents a GS1 application identifier
/// </summary>
public class Gs1ApplicationIdentifier
{
    private string _toString;

    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="rawValue"></param>
    /// <param name="prefix"></param>
    /// <param name="dataContent"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public Gs1ApplicationIdentifier(
        string rawValue,
        string prefix,
        string dataContent
    )
    {
        rawValue.NotNull(nameof(rawValue));
        rawValue.NotNullOrWhiteSpace(nameof(rawValue));

        prefix.NotNull(nameof(prefix));
        prefix.NotNullOrWhiteSpace(nameof(prefix));

        dataContent.NotNull(nameof(dataContent));
        dataContent.NotNullOrWhiteSpace(nameof(dataContent));

        RawValue = rawValue;
        Prefix = prefix;
        DataContent = dataContent;
    }

    /// <summary>
    /// Application identifier original value
    /// </summary>
    public string RawValue { get; }

    /// <summary>
    /// Application identifier prefix
    /// </summary>
    public string Prefix { get; }

    /// <summary>
    /// Application identifier data content
    /// </summary>
    public string DataContent { get; }

    /// <inheritdoc />
    public override string ToString() => _toString ??= string.Concat("(", Prefix, ")", DataContent);
}