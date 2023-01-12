namespace SimpleSoft.Gs1Parser;

/// <summary>
/// Represents a GS1 entity
/// </summary>
public interface IGs1 : IReadOnlyDictionary<string, Gs1ApplicationIdentifier>
{
    /// <summary>
    /// GS1 original value
    /// </summary>
    public string RawValue { get; }
}