namespace SimpleSoft.Gs1Parser;

/// <summary>
/// Represents a GS1 application identifier
/// </summary>
public class Gs1ApplicationIdentifier
{
    /// <summary>
    /// Creates a new instance
    /// </summary>
    /// <param name="value"></param>
    /// <param name="prefix"></param>
    /// <param name="dataContent"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public Gs1ApplicationIdentifier(
        string value,
        string prefix,
        string dataContent
    )
    {
        Value = value ?? throw new ArgumentNullException(nameof(value));
        Prefix = prefix ?? throw new ArgumentNullException(nameof(prefix));
        DataContent = dataContent ?? throw new ArgumentNullException(nameof(dataContent));
    }

    /// <summary>
    /// Application identifier original value
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Application identifier prefix
    /// </summary>
    public string Prefix { get; }

    /// <summary>
    /// Application identifier data content
    /// </summary>
    public string DataContent { get; }
}