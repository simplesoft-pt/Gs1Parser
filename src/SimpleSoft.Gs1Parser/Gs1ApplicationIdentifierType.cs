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

    #region GS1 Application Identifiers starting with digit 2

    /// <summary>
    /// Internal product variant: AI (20)
    /// </summary>
    public const string Variant = "20";

    /// <summary>
    /// Serial number: AI (21)
    /// </summary>
    public const string Serial = "21";

    /// <summary>
    /// Consumer product variant: AI (22)
    /// </summary>
    public const string Cpv = "22";

    /// <summary>
    /// Third Party Controlled, Serialized Extension of Global Trade Item Number (GTIN) (TPX): AI(235)
    /// </summary>
    public const string Tpx = "235";

    /// <summary>
    /// Additional product identification assigned by the manufacturer: AI (240)
    /// </summary>
    public const string AdditionalId = "240";

    /// <summary>
    /// Customer part number: AI (241)
    /// </summary>
    public const string CustPartNo = "241";

    /// <summary>
    /// Made-to-Order variation number: AI (242)
    /// </summary>
    public const string MtoVariant = "242";

    /// <summary>
    /// Packaging component number: AI (243)
    /// </summary>
    public const string Pcn = "243";

    /// <summary>
    /// Secondary serial number: AI (250)
    /// </summary>
    public const string SecondarySerial = "250";

    /// <summary>
    /// Reference to source entity: AI (251)
    /// </summary>
    public const string RefToSource = "251";

    /// <summary>
    /// Global Document Type Identifier (GDTI): AI (253)
    /// </summary>
    public const string Gdti = "253";

    /// <summary>
    /// Global Location Number (GLN) extension component: AI (254)
    /// </summary>
    public const string GlnExtensionComponent = "254";

    /// <summary>
    /// Global Coupon Number (GCN): AI (255)
    /// </summary>
    public const string Gcn = "255";

    #endregion
}