namespace SimpleSoft.Gs1Parser;

/// <summary>
/// Function responsible for extracting a given application identifier.
/// </summary>
/// <param name="value">The GS1 string value</param>
/// <param name="startIndex">The start index to lookup for the application identifier</param>
/// <param name="prefix">Application identifier prefix</param>
/// <param name="separator">Character representing the FNC1 separator</param>
/// <returns></returns>
public delegate Gs1ApplicationIdentifier Gs1ApplicationIdentifierExtractor(
    string value,
    int startIndex,
    string prefix,
    char separator
);