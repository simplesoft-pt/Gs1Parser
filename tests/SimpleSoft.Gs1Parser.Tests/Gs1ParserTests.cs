namespace SimpleSoft.Gs1Parser;

public class Gs1ParserTests
{
    [Fact]
    public void DefaultSingleton_NotNull()
    {
        var parser = Gs1Parser.Default;

        Assert.NotNull(parser);
    }

    [Fact]
    public void Constructor_NullOptions_ArgumentNullException()
    {
        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            var _ = new Gs1Parser(null);
        });

        Assert.NotNull(ex);
        Assert.Equal("options", ex.ParamName);
    }

    [Fact]
    public void Parse_NullValue_ArgumentNullException()
    {
        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            new Gs1Parser().Parse(null);
        });

        Assert.NotNull(ex);
        Assert.Equal("rawValue", ex.ParamName);
    }

    [Theory]
    [InlineData("17260630", Gs1ApplicationIdentifierType.UseBy, "260630")]
    [InlineData("17260630;", Gs1ApplicationIdentifierType.UseBy, "260630")]
    public void Parse_KnownPrefix_Single_FixedLength_Succeeds(string rawValue, string prefix, string dataContent)
    {
        var parser = new Gs1Parser();

        var gs1 = parser.Parse(rawValue);

        Assert.NotNull(gs1);
        Assert.Same(rawValue, gs1.RawValue);

        var (key, value) = Assert.Single(gs1);

        Assert.NotNull(key);
        Assert.Equal(prefix, key);

        Assert.NotNull(value);

        Assert.NotNull(value.RawValue);
        Assert.Equal(rawValue, value.RawValue);

        Assert.NotNull(value.Prefix);
        Assert.Equal(prefix, value.Prefix);

        Assert.NotNull(value.DataContent);
        Assert.Equal(dataContent, value.DataContent);
    }

    [Theory]
    [InlineData("10AB111", Gs1ApplicationIdentifierType.Batch, "AB111")]
    [InlineData("10AB111;", Gs1ApplicationIdentifierType.Batch, "AB111")]
    [InlineData("10AB111AB111AB111AB111", Gs1ApplicationIdentifierType.Batch, "AB111AB111AB111AB111")]
    [InlineData("10AB111AB111AB111AB111;", Gs1ApplicationIdentifierType.Batch, "AB111AB111AB111AB111")]
    public void Parse_KnownPrefix_Single_VariableLength_Succeeds(string rawValue, string prefix, string dataContent)
    {
        var parser = new Gs1Parser();

        var gs1 = parser.Parse(rawValue);

        Assert.NotNull(gs1);
        Assert.Same(rawValue, gs1.RawValue);

        var (key, value) = Assert.Single(gs1);

        Assert.NotNull(key);
        Assert.Equal(prefix, key);

        Assert.NotNull(value);

        Assert.NotNull(value.RawValue);
        Assert.Equal(rawValue, value.RawValue);

        Assert.NotNull(value.Prefix);
        Assert.Equal(prefix, value.Prefix);

        Assert.NotNull(value.DataContent);
        Assert.Equal(dataContent, value.DataContent);
    }

    [Theory]
    [InlineData("17")]
    [InlineData("17;")]
    [InlineData("172606")]
    [InlineData("172606;")]
    public void Parse_KnownPrefix_Single_FixedLength_MissingLength_FormatException(string rawValue)
    {
        var parser = new Gs1Parser();

        var ex = Assert.Throws<FormatException>(() =>
        {
            parser.Parse(rawValue);
        });

        Assert.Contains("doesn't have the required length", ex.Message);
    }

    [Theory]
    [InlineData("10")]
    [InlineData("10;")]
    public void Parse_KnownPrefix_Single_VariableLength_MissingLength_FormatException(string rawValue)
    {
        var parser = new Gs1Parser();

        var ex = Assert.Throws<FormatException>(() =>
        {
            parser.Parse(rawValue);
        });

        Assert.Contains("doesn't have minimum length of 1", ex.Message);
    }
}