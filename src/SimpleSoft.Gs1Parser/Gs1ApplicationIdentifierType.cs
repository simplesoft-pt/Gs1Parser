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
    /// Logistic weight (Kilograms): AI (330)
    /// </summary>
    public const string LogisticWeightKilograms = "330";

    /// <summary>
    /// Logistic length or first dimension (Meters): AI (331)
    /// </summary>
    public const string LogisticLengthMeters = "331";

    /// <summary>
    /// Logistic width, diameter, or second dimension (Meters): AI (332)
    /// </summary>
    public const string LogisticWidthMeters = "332";

    /// <summary>
    /// Logistic depth, thickness, height, or third dimension (Meters): AI (333)
    /// </summary>
    public const string LogisticHeightMeters = "333";

    /// <summary>
    /// Logistic area (Square meters): AI (334)
    /// </summary>
    public const string LogisticAreaSquareMeters = "334";

    /// <summary>
    /// Logistic volume (Liters): AI (335)
    /// </summary>
    public const string LogisticVolumeLiters = "335";

    /// <summary>
    /// Logistic volume (Cubic meters): AI (336)
    /// </summary>
    public const string LogisticVolumeCubicMeters = "336";

    /// <summary>
    /// Kilograms per square meter (Cubic yards): AI (337)
    /// </summary>
    public const string KilogramsPerSquareMeter = "337";

    /// <summary>
    /// Logistic weight (Pounds): AI (340)
    /// </summary>
    public const string LogisticWightPounds = "340";

    /// <summary>
    /// Logistic length or first dimension (Inches): AI (341)
    /// </summary>
    public const string LogisticLengthInches = "341";

    /// <summary>
    /// Logistic length or first dimension (Feet): AI (342)
    /// </summary>
    public const string LogisticLengthFeet = "342";

    /// <summary>
    /// Logistic length or first dimension (Yards): AI (343)
    /// </summary>
    public const string LogisticLengthYards = "343";

    /// <summary>
    /// Logistic width, diameter, or second dimension (Inches): AI (344)
    /// </summary>
    public const string LogisticWidthInches = "344";

    /// <summary>
    /// Logistic width, diameter, or second dimension (Feet): AI (345)
    /// </summary>
    public const string LogisticWidthFeet = "345";

    /// <summary>
    /// Logistic width, diameter, or second dimension (Yards): AI (346)
    /// </summary>
    public const string LogisticWidthYards = "346";

    /// <summary>
    /// Logistic depth, thickness, height, or third dimension (Inches): AI (347)
    /// </summary>
    public const string LogisticHeightInches = "347";

    /// <summary>
    /// Logistic depth, thickness, height, or third dimension (Feet): AI (348)
    /// </summary>
    public const string LogisticHeightFeet = "348";

    /// <summary>
    /// Logistic depth, thickness, height, or third dimension (Inches): AI (349)
    /// </summary>
    public const string LogisticHeightYards = "349";

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
    /// Logistic area (Square inches): AI (353)
    /// </summary>
    public const string LogisticAreaSquareInches = "353";

    /// <summary>
    /// Logistic area (Square feet): AI (354)
    /// </summary>
    public const string LogisticAreaSquareFeet = "354";

    /// <summary>
    /// Logistic area (Square yards): AI (355)
    /// </summary>
    public const string LogisticAreaSquareYards = "355";

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
    /// Logistic volume (Quarts): AI (362)
    /// </summary>
    public const string LogisticVolumeQuarts = "362";

    /// <summary>
    /// Logistic volume (Gallons): AI (363)
    /// </summary>
    public const string LogisticVolumeGallons = "363";

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

    /// <summary>
    /// Logistic volume (Cubic inches): AI (367)
    /// </summary>
    public const string LogisticVolumeCubicInches = "367";

    /// <summary>
    /// Logistic volume (Cubic feet): AI (368)
    /// </summary>
    public const string LogisticVolumeCubicFeet = "368";

    /// <summary>
    /// Logistic volume (Cubic yards): AI (369)
    /// </summary>
    public const string LogisticVolumeCubicYards = "369";

    /// <summary>
    /// Count of trade items or trade item pieces contained in a logistic unit: AI (37)
    /// </summary>
    public const string Count = "37";

    /// <summary>
    /// Amount payable or coupon value - Single monetary area: AI (390)
    /// </summary>
    public const string Amount = "390";

    /// <summary>
    /// Amount payable and ISO currency code: AI (391)
    /// </summary>
    public const string AmountIso = "391";

    /// <summary>
    /// Amount payable for a variable measure trade item – Single monetary area: AI (392)
    /// </summary>
    public const string Price = "392";

    /// <summary>
    /// Amount payable for a variable measure trade item and ISO currency code: AI (393)
    /// </summary>
    public const string PriceIso = "393";

    /// <summary>
    /// Percentage discount of a coupon: AI (394)
    /// </summary>
    public const string PrcntOff = "394";

    /// <summary>
    /// Amount payable per unit of measure single monetary area (variable measure trade item): AI (395)
    /// </summary>
    public const string PriceUoM = "395";

    #endregion

    #region GS1 Application Identifiers starting with digit 4

    /// <summary>
    /// Customer’s purchase order number: AI (400)
    /// </summary>
    public const string OrderNumber = "400";

    /// <summary>
    /// Global Identification Number for Consignment (GINC): AI (401)
    /// </summary>
    public const string Ginc = "401";

    /// <summary>
    /// Global Shipment Identification Number (GSIN): AI (402)
    /// </summary>
    public const string Gsin = "402";

    /// <summary>
    /// Routing code: AI (403)
    /// </summary>
    public const string Route = "403";

    /// <summary>
    /// Ship to - Deliver to Global Location Number (GLN): AI (410)
    /// </summary>
    public const string ShipToLoc = "410";

    /// <summary>
    /// Bill to - Invoice to Global Location Number (GLN): AI (411)
    /// </summary>
    public const string BillTo = "411";

    /// <summary>
    /// Purchased from Global Location Number (GLN): AI (412)
    /// </summary>
    public const string PurchaseFrom = "412";

    /// <summary>
    /// Ship for - Deliver for - Forward to Global Location Number (GLN): AI (413)
    /// </summary>
    public const string ShipForLoc = "413";

    /// <summary>
    /// Identification of a physical location - Global Location Number (GLN): AI (414)
    /// </summary>
    public const string LocNo = "414";

    /// <summary>
    /// Global Location Number (GLN) of the invoicing party: AI (415)
    /// </summary>
    public const string PayTo = "415";

    /// <summary>
    /// Global Location Number (GLN) of the production or service location: AI (416)
    /// </summary>
    public const string ProdServLoc = "416";

    /// <summary>
    /// Party Global Location Number (GLN): AI (417)
    /// </summary>
    public const string Party = "417";

    /// <summary>
    /// Ship-to / Deliver-to postal code within a single postal authority: AI (420)
    /// </summary>
    public const string ShipToPost = "420";

    /// <summary>
    /// Ship-to / Deliver-to postal code with three-digit ISO country code: AI (421)
    /// </summary>
    public const string ShipToPostIso = "421";

    /// <summary>
    /// Country of origin of a trade item: AI (422)
    /// </summary>
    public const string Origin = "422";

    /// <summary>
    /// Country of initial processing: AI (423)
    /// </summary>
    public const string CountryInitialProcess = "423";

    /// <summary>
    /// Country of processing: AI (424)
    /// </summary>
    public const string CountryProcess = "424";

    /// <summary>
    /// Country of disassembly: AI (425)
    /// </summary>
    public const string CountryDisassembly = "425";

    /// <summary>
    /// Country covering full process chain: AI (426)
    /// </summary>
    public const string CountryFullProcess = "426";

    /// <summary>
    /// Country subdivision of origin code for a trade item: AI (427)
    /// </summary>
    public const string OriginSubdivision = "427";

    /// <summary>
    /// Ship-to / Deliver-to Company name: AI (4300)
    /// </summary>
    public const string DeliverToComp = "4300";

    /// <summary>
    /// Ship-to / Deliver-to contact name: AI (4301)
    /// </summary>
    public const string DeliverToName = "4301";

    /// <summary>
    /// Ship-to / Deliver-to address line 1: AI (4302)
    /// </summary>
    public const string DeliverToAdd1 = "4302";

    /// <summary>
    /// Ship-to / Deliver-to address line 2: AI (4303)
    /// </summary>
    public const string DeliverToAdd2 = "4303";

    /// <summary>
    /// Ship-to / Deliver-to suburb: AI (4304)
    /// </summary>
    public const string DeliverToSub = "4304";

    /// <summary>
    /// Ship-to / Deliver-to locality: AI (4305)
    /// </summary>
    public const string DeliverToLoc = "4305";

    /// <summary>
    /// Ship-to / Deliver-to region: AI (4306)
    /// </summary>
    public const string DeliverToReg = "4306";

    /// <summary>
    /// Ship-to / Deliver-to country code: AI (4307)
    /// </summary>
    public const string DeliverToCountry = "4307";

    /// <summary>
    /// Ship-to / Deliver-to telephone number: AI (4308)
    /// </summary>
    public const string DeliverToPhone = "4308";

    /// <summary>
    /// Ship-to / Deliver-to GEO location: AI (4309)
    /// </summary>
    public const string DeliverToGeo = "4309";

    /// <summary>
    /// Return-to company name: AI (4310)
    /// </summary>
    public const string RtnToComp = "4310";

    /// <summary>
    /// Return-to contact name: AI (4311)
    /// </summary>
    public const string RtnToName = "4311";

    /// <summary>
    /// Return-to address line 1: AI (4312)
    /// </summary>
    public const string RtnToAdd1 = "4312";

    /// <summary>
    /// Return-to address line 2: AI (4313)
    /// </summary>
    public const string RtnToAdd2 = "4313";

    /// <summary>
    /// Return-to suburb: AI (4314)
    /// </summary>
    public const string RtnToSub = "4314";

    /// <summary>
    /// Return-to locality: AI (4315)
    /// </summary>
    public const string RtnToLoc = "4315";

    /// <summary>
    /// Return-to region: AI (4316)
    /// </summary>
    public const string RtnToReg = "4316";

    /// <summary>
    /// Return-to country code: AI (4317)
    /// </summary>
    public const string RtnToCountry = "4317";

    /// <summary>
    /// Return-to postal code: AI (4318)
    /// </summary>
    public const string RtnToPost = "4318";

    /// <summary>
    /// Return-to telephone number: AI (4319)
    /// </summary>
    public const string RtnToPhone = "4319";

    /// <summary>
    /// Service code description: AI (4320)
    /// </summary>
    public const string SrvDescription = "4320";

    /// <summary>
    /// Dangerous goods flag: AI (4321)
    /// </summary>
    public const string DangerousGoods = "4321";

    /// <summary>
    /// Authority to leave flag: AI (4322)
    /// </summary>
    public const string AuthLeave = "4322";

    /// <summary>
    /// Signature required flag: AI (4323)
    /// </summary>
    public const string SigRequired = "4323";

    /// <summary>
    /// Not before delivery date/time: AI (4324)
    /// </summary>
    public const string NbefDelDt = "4324";

    /// <summary>
    /// Not after delivery date/time: AI (4325)
    /// </summary>
    public const string NaftDelDt = "4325";

    /// <summary>
    /// Release date: AI (4326)
    /// </summary>
    public const string RelDate = "4326";

    #endregion

    #region GS1 Application Identifiers starting with digit 7

    /// <summary>
    /// NATO Stock Number (NSN): AI (7001)
    /// </summary>
    public const string Nsn = "7001";

    /// <summary>
    /// UN/ECE meat carcasses and cuts classification: AI (7002)
    /// </summary>
    public const string MeatCut = "7002";

    /// <summary>
    /// Expiration date and time: AI (7003)
    /// </summary>
    public const string ExpiryTime = "7003";

    /// <summary>
    /// Active potency: AI (7004)
    /// </summary>
    public const string ActivePotency = "7004";

    /// <summary>
    /// Catch area: AI (7005)
    /// </summary>
    public const string CatchArea = "7005";

    /// <summary>
    /// First freeze date: AI (7006)
    /// </summary>
    public const string FirstFreezeDate = "7006";

    /// <summary>
    /// Harvest date: AI (7007)
    /// </summary>
    public const string HarvestDate = "7007";

    /// <summary>
    /// Species for fishery purposes: AI (7008)
    /// </summary>
    public const string AquaticSpecies = "7008";

    /// <summary>
    /// Fishing gear type: AI (7009)
    /// </summary>
    public const string FishingGearType = "7009";

    /// <summary>
    /// Production method: AI (7010)
    /// </summary>
    public const string ProdMethod = "7010";

    /// <summary>
    /// Test by date: AI (7011)
    /// </summary>
    public const string TestByDate = "7011";

    /// <summary>
    /// Refurbishment lot ID: AI (7020)
    /// </summary>
    public const string RefurbLot = "7020";

    /// <summary>
    /// Functional status: AI (7021)
    /// </summary>
    public const string FuncStat = "7021";

    /// <summary>
    /// Revision status: AI (7022)
    /// </summary>
    public const string RevStat = "7022";

    /// <summary>
    /// Global Individual Asset Identifier of an assembly: AI (7023)
    /// </summary>
    public const string GiaiAssembly = "7023";

    /// <summary>
    /// Number of processor with three-digit ISO country code: AI (703s)
    /// </summary>
    public const string Processor0 = "7030";

    /// <summary>
    /// Number of processor with three-digit ISO country code: AI (703s)
    /// </summary>
    public const string Processor1 = "7031";

    /// <summary>
    /// Number of processor with three-digit ISO country code: AI (703s)
    /// </summary>
    public const string Processor2 = "7032";

    /// <summary>
    /// Number of processor with three-digit ISO country code: AI (703s)
    /// </summary>
    public const string Processor3 = "7033";

    /// <summary>
    /// Number of processor with three-digit ISO country code: AI (703s)
    /// </summary>
    public const string Processor4 = "7034";

    /// <summary>
    /// Number of processor with three-digit ISO country code: AI (703s)
    /// </summary>
    public const string Processor5 = "7035";

    /// <summary>
    /// Number of processor with three-digit ISO country code: AI (703s)
    /// </summary>
    public const string Processor6 = "7036";

    /// <summary>
    /// Number of processor with three-digit ISO country code: AI (703s)
    /// </summary>
    public const string Processor7 = "7037";

    /// <summary>
    /// Number of processor with three-digit ISO country code: AI (703s)
    /// </summary>
    public const string Processor8 = "7038";

    /// <summary>
    /// Number of processor with three-digit ISO country code: AI (703s)
    /// </summary>
    public const string Processor9 = "7039";

    /// <summary>
    /// GS1 UIC with Extension 1 and Importer index: AI (7040)
    /// </summary>
    public const string UicExt = "7040";

    /// <summary>
    /// National Healthcare Reimbursement Number (NHRN) - Germany IFA: AI (710)
    /// </summary>
    public const string NhrnGermany = "710";

    /// <summary>
    /// National Healthcare Reimbursement Number (NHRN) - France CIP: AI (711)
    /// </summary>
    public const string NhrnFrance = "711";

    /// <summary>
    /// National Healthcare Reimbursement Number (NHRN) - Spain National Code: AI (712)
    /// </summary>
    public const string NhrnSpain = "712";

    /// <summary>
    /// National Healthcare Reimbursement Number (NHRN) - Brazil ANVISA: AI (713)
    /// </summary>
    public const string NhrnBrazil = "713";

    /// <summary>
    /// National Healthcare Reimbursement Number (NHRN) - Portugal INFARMED: AI (714)
    /// </summary>
    public const string NhrnPortugal = "714";

    /// <summary>
    /// National Healthcare Reimbursement Number (NHRN) - United States of America FDA: AI (715)
    /// </summary>
    public const string NhrnUsa = "715";

    /// <summary>
    /// Certification reference: AI (723s)
    /// </summary>
    public const string Cert0 = "7230";

    /// <summary>
    /// Certification reference: AI (723s)
    /// </summary>
    public const string Cert1 = "7231";

    /// <summary>
    /// Certification reference: AI (723s)
    /// </summary>
    public const string Cert2 = "7232";

    /// <summary>
    /// Certification reference: AI (723s)
    /// </summary>
    public const string Cert3 = "7233";

    /// <summary>
    /// Certification reference: AI (723s)
    /// </summary>
    public const string Cert4 = "7234";

    /// <summary>
    /// Certification reference: AI (723s)
    /// </summary>
    public const string Cert5 = "7235";

    /// <summary>
    /// Certification reference: AI (723s)
    /// </summary>
    public const string Cert6 = "7236";

    /// <summary>
    /// Certification reference: AI (723s)
    /// </summary>
    public const string Cert7 = "7237";

    /// <summary>
    /// Certification reference: AI (723s)
    /// </summary>
    public const string Cert8 = "7238";

    /// <summary>
    /// Certification reference: AI (723s)
    /// </summary>
    public const string Cert9 = "7239";

    /// <summary>
    /// Protocol ID: AI (7240)
    /// </summary>
    public const string Protocol = "7240";

    #endregion

    #region GS1 Application Identifiers starting with digit 8

    /// <summary>
    /// Roll products - width, length, core diameter, direction, splices: AI (8001)
    /// </summary>
    public const string Dimensions = "8001";

    /// <summary>
    /// Cellular mobile telephone identifier: AI (8002)
    /// </summary>
    public const string CmtNo = "8002";

    /// <summary>
    /// Global Returnable Asset Identifier (GRAI): AI (8003)
    /// </summary>
    public const string Grai = "8003";

    /// <summary>
    /// Global Individual Asset Identifier (GIAI): AI (8004)
    /// </summary>
    public const string Giai = "8004";

    /// <summary>
    /// Price per unit of measure: AI (8005)
    /// </summary>
    public const string PricePerUnit = "8005";

    /// <summary>
    /// Identification of an individual trade item (ITIP) piece: AI (8006)
    /// </summary>
    public const string Itip = "8006";

    /// <summary>
    /// International Bank Account Number (IBAN): AI (8007)
    /// </summary>
    public const string Iban = "8007";

    /// <summary>
    /// Date and time of production: AI (8008)
    /// </summary>
    public const string ProdTime = "8008";

    /// <summary>
    /// Optically readable sensor indicator: AI (8009)
    /// </summary>
    public const string Optsen = "8009";

    /// <summary>
    /// Component/Part Identifier (CPID): AI (8010)
    /// </summary>
    public const string Cpid = "8010";

    /// <summary>
    /// Component/Part Identifier serial number: AI (8011)
    /// </summary>
    public const string CpidSerial = "8011";

    /// <summary>
    /// Software version: AI (8012)
    /// </summary>
    public const string Version = "8012";

    /// <summary>
    /// Global Model Number (GMN): AI (8013)
    /// </summary>
    public const string Gmn = "8013";

    /// <summary>
    /// Global Service Relation Number (GSRN - PROVIDER): AI (8017)
    /// </summary>
    public const string GsrnProvider = "8017";

    /// <summary>
    /// Global Service Relation Number (GSRN - RECIPIENT): AI (8018)
    /// </summary>
    public const string GsrnRecipient = "8018";

    /// <summary>
    /// Service Relation Instance Number (SRIN): AI (8019)
    /// </summary>
    public const string Srin = "8019";

    /// <summary>
    /// Payment slip reference number: AI (8020)
    /// </summary>
    public const string RefNo = "8020";

    /// <summary>
    /// Identification of pieces of a trade item (ITIP) contained in a logistic unit: AI (8026)
    /// </summary>
    public const string ItipContent = "8026";

    /// <summary>
    /// Coupon code identification for use in North America: AI (8110)
    /// </summary>
    public const string CouponCodeNorthAmerica = "8110";

    /// <summary>
    /// Loyalty points of a coupon: AI (8111)
    /// </summary>
    public const string Points = "8111";

    /// <summary>
    /// Extended packaging URL: AI (8200)
    /// </summary>
    public const string ProductUrl = "8200";

    #endregion

    #region GS1 Application Identifiers starting with digit 9

    /// <summary>
    /// Information mutually agreed between trading partners: AI (90)
    /// </summary>
    public const string Internal0 = "90";

    /// <summary>
    /// Company internal information: AIs (91 - 99)
    /// </summary>
    public const string Internal1 = "91";

    /// <summary>
    /// Company internal information: AIs (91 - 99)
    /// </summary>
    public const string Internal2 = "92";

    /// <summary>
    /// Company internal information: AIs (91 - 99)
    /// </summary>
    public const string Internal3 = "93";

    /// <summary>
    /// Company internal information: AIs (91 - 99)
    /// </summary>
    public const string Internal4 = "94";

    /// <summary>
    /// Company internal information: AIs (91 - 99)
    /// </summary>
    public const string Internal5 = "95";

    /// <summary>
    /// Company internal information: AIs (91 - 99)
    /// </summary>
    public const string Internal6 = "96";

    /// <summary>
    /// Company internal information: AIs (91 - 99)
    /// </summary>
    public const string Internal7 = "97";

    /// <summary>
    /// Company internal information: AIs (91 - 99)
    /// </summary>
    public const string Internal8 = "98";

    /// <summary>
    /// Company internal information: AIs (91 - 99)
    /// </summary>
    public const string Internal9 = "99";

    #endregion
}