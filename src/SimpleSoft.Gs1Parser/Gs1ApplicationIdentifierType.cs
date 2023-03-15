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

    #region GS1 Application Identifiers starting with digit 3

    /// <summary>
    /// Variable count of items: AI (30)
    /// </summary>
    public const string VarCount = "30";

    /// <summary>
    /// Net weight (Kilograms): AI (310)
    /// </summary>
    public const string NetWeightKilograms = "310";

    /// <summary>
    /// Length or first dimension (Meters): AI (311)
    /// </summary>
    public const string LengthMeters = "311";

    /// <summary>
    /// Width, diameter, or second dimension (Meters): AI (312)
    /// </summary>
    public const string WidthMeters = "312";

    /// <summary>
    /// Depth, thickness, height, or third dimension (Meters): AI (313)
    /// </summary>
    public const string HeightMeters = "313";

    /// <summary>
    /// Area (Square meters): AI (314)
    /// </summary>
    public const string AreaSquareMeters = "314";

    /// <summary>
    /// Net volume (Liters): AI (315)
    /// </summary>
    public const string NetVolumeLiters = "315";

    /// <summary>
    /// Net volume (Cubic meters): AI (316)
    /// </summary>
    public const string NetVolumeCubicMeters = "316";

    /// <summary>
    /// Net weight (Pounds): AI (320)
    /// </summary>
    public const string NetWeightPounds = "320";

    /// <summary>
    /// Length or first dimension (Inches): AI (321)
    /// </summary>
    public const string LengthInches = "321";

    /// <summary>
    /// Length or first dimension (Feet): AI (322)
    /// </summary>
    public const string LengthFeet = "322";

    /// <summary>
    /// Length or first dimension (Yards): AI (323)
    /// </summary>
    public const string LengthYards = "323";

    /// <summary>
    /// Width, diameter, or second dimension (Inches): AI (324)
    /// </summary>
    public const string WidthInches = "324";

    /// <summary>
    /// Width, diameter, or second dimension (Feet): AI (325)
    /// </summary>
    public const string WidthFeet = "325";

    /// <summary>
    /// Width, diameter, or second dimension (Yards): AI (326)
    /// </summary>
    public const string WidthYards = "326";

    /// <summary>
    /// Depth, thickness, height, or third dimension (Inches): AI (327)
    /// </summary>
    public const string HeightInches = "327";

    /// <summary>
    /// Depth, thickness, height, or third dimension (Feet): AI (328)
    /// </summary>
    public const string HeightFeet = "328";

    /// <summary>
    /// Depth, thickness, height, or third dimension (Yards): AI (329)
    /// </summary>
    public const string HeightYards = "329";

    /// <summary>
    /// Area (Square inches): AI (350)
    /// </summary>
    public const string AreaSquareInches = "350";

    /// <summary>
    /// Area (Square feet): AI (351)
    /// </summary>
    public const string AreaSquareFeet = "351";

    /// <summary>
    /// Area (Square yards): AI (352)
    /// </summary>
    public const string AreaSquareYards = "352";

    /// <summary>
    /// Net weight (Troy ounces): AI (356)
    /// </summary>
    public const string NetWeightTroyOunces = "356";

    /// <summary>
    /// Net weight (or volume) (Ounces): AI (357)
    /// </summary>
    public const string NetWeightOunces = "357";

    /// <summary>
    /// Net volume (Quarts): AI (360)
    /// </summary>
    public const string NetVolumeQuarts = "360";

    /// <summary>
    /// Net volume (Gallons): AI (361)
    /// </summary>
    public const string NetVolumeGallons = "361";

    /// <summary>
    /// Net volume (Cubic inches): AI (364)
    /// </summary>
    public const string NetVolumeCubicInches = "364";

    /// <summary>
    /// Net volume (Cubic feet): AI (365)
    /// </summary>
    public const string NetVolumeCubicFeet = "365";

    /// <summary>
    /// Net volume (Cubic yards): AI (366)
    /// </summary>
    public const string NetVolumeCubicYards = "366";

    #endregion
}