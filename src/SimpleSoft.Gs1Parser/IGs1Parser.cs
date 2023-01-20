namespace SimpleSoft.Gs1Parser;

/// <summary>
/// Represents a GS1 parser.
/// </summary>
public interface IGs1Parser
{
    /// <summary>
    /// Parses a given GS1 string retuning a collection of application identifiers
    /// indexed by their prefix.
    /// </summary>
    /// <param name="rawValue">The GS1 string to parse</param>
    /// <returns>The collection of application identifiers</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="FormatException"></exception>
    IGs1 Parse(string rawValue);
}