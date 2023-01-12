namespace SimpleSoft.Gs1Parser;

public class Gs1ApplicationIdentifierTests
{
    [Fact]
    public void Constructor_NullValue_ArgumentNullException()
    {
        string? rawValue = null;

        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            var _ = new Gs1ApplicationIdentifier(
                rawValue,
                ".",
                "."
            );
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(rawValue), ex.ParamName);
    }

    [Fact]
    public void Constructor_NullPrefix_ArgumentNullException()
    {
        string? prefix = null;

        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            var _ = new Gs1ApplicationIdentifier(
                ".",
                prefix,
                "."
            );
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(prefix), ex.ParamName);
    }

    [Fact]
    public void Constructor_NullDataContent_ArgumentNullException()
    {
        string? dataContent = null;

        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            var _ = new Gs1ApplicationIdentifier(
                ".",
                ".",
                dataContent
            );
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(dataContent), ex.ParamName);
    }

    [Theory]
    [InlineData("")]
    [InlineData("     ")]
    public void Constructor_InvalidValue_ArgumentException(string rawValue)
    {
        var ex = Assert.Throws<ArgumentException>(() =>
        {
            var _ = new Gs1ApplicationIdentifier(
                rawValue,
                ".",
                "."
            );
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(rawValue), ex.ParamName);
    }

    [Theory]
    [InlineData("")]
    [InlineData("     ")]
    public void Constructor_InvalidPrefix_ArgumentException(string prefix)
    {
        var ex = Assert.Throws<ArgumentException>(() =>
        {
            var _ = new Gs1ApplicationIdentifier(
                ".",
                prefix,
                "."
            );
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(prefix), ex.ParamName);
    }

    [Theory]
    [InlineData("")]
    [InlineData("     ")]
    public void Constructor_InvalidDataContent_ArgumentException(string dataContent)
    {
        var ex = Assert.Throws<ArgumentException>(() =>
        {
            var _ = new Gs1ApplicationIdentifier(
                ".",
                ".",
                dataContent
            );
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(dataContent), ex.ParamName);
    }

    [Fact]
    public void Constructor_ValidParams_PropertiesSame()
    {
        const string rawValue = "rawValue";
        const string prefix = "prefix";
        const string dataContent = "dataContent";

        var ai = new Gs1ApplicationIdentifier(
            rawValue,
            prefix,
            dataContent
        );

        Assert.Same(rawValue, ai.RawValue);
        Assert.Same(prefix, ai.Prefix);
        Assert.Same(dataContent, ai.DataContent);
    }
}