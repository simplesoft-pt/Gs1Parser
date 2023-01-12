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
    [InlineData("17260630", "17", "260630")]
    [InlineData("17260630;", "17", "260630")]
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
    [InlineData("10AB111", "10", "AB111")]
    [InlineData("10AB111;", "10", "AB111")]
    [InlineData("10AB111AB111AB111AB111", "10", "AB111AB111AB111AB111")]
    [InlineData("10AB111AB111AB111AB111;", "10", "AB111AB111AB111AB111")]
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
}