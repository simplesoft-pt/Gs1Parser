namespace SimpleSoft.Gs1Parser;

/// <summary>
/// Represents the options user by GS1 parsers.
/// </summary>
public class Gs1ParserOptions
{
    /// <summary>
    /// Character to be used as the FNC1 separator. Defaults to ';'.
    /// </summary>
    public char Separator { get; set; } = ';';

    /// <summary>
    /// Default options for GS1 parsers.
    /// </summary>
    public static readonly Gs1ParserOptions Default = new();
}