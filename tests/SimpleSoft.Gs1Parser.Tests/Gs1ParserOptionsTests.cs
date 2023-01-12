namespace SimpleSoft.Gs1Parser;

public class Gs1ParserOptionsTests
{
    [Fact]
    public void Constructor_NoParameters_DefaultPropertyValues()
    {
        var options = new Gs1ParserOptions();

        Assert.Equal(';', options.Separator);
        Assert.Null(options.CustomExtractors);
    }

    [Fact]
    public void DefaultSingleton_DefaultPropertyValues()
    {
        var options = Gs1ParserOptions.Default;

        Assert.NotNull(options);
        Assert.Equal(';', options.Separator);
        Assert.Null(options.CustomExtractors);
    }
}