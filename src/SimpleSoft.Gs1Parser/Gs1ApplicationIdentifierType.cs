namespace SimpleSoft.Gs1Parser;

/// <summary>
/// Represents a GS1 application identifier prefixes
/// </summary>
public static class Gs1ApplicationIdentifierType
{
    #region GS1 Application Identifiers starting with digit 1

    /// <summary>
    /// Identification of a logistic unit (SSCC): AI (00)
    /// </summary>
    public const string Sscc = "00";

    /// <summary>
    /// Identification of a trade item (GTIN): AI (01)
    /// </summary>
    public const string Gtin = "01";

    /// <summary>
    /// Identification of trade items contained in a logistic unit: AI (02)
    /// </summary>
    public const string Content = "02";

    /// <summary>
    /// Batch or lot number: AI (10)
    /// </summary>
    public const string Batch = "10";

    /// <summary>
    /// Production date: AI (11)
    /// </summary>
    public const string ProdDate = "11";

    /// <summary>
    /// Due date for amount on payment slip: AI (12)
    /// </summary>
    public const string DueDate = "12";

    /// <summary>
    /// Packaging date: AI (13)
    /// </summary>
    public const string PackDate = "13";

    /// <summary>
    /// Best before date: AI (15)
    /// </summary>
    public const string BestBefore = "15";

    /// <summary>
    /// Sell by date: AI (16)
    /// </summary>
    public const string SellBy = "16";

    /// <summary>
    /// Expiration date: AI (17)
    /// </summary>
    public const string UseBy = "17";

    #endregion
}