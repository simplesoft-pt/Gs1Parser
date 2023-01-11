namespace SimpleSoft.Gs1Parser;

public class Gs1ApplicationIdentifierTests
{
    [Fact]
    public void Constructor_NullValue_ArgumentNullException()
    {
        string? value = null;

        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            var _ = new Gs1ApplicationIdentifier(
                value,
                ".",
                "."
            );
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(value), ex.ParamName);
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
    public void Constructor_InvalidValue_ArgumentException(string value)
    {
        var ex = Assert.Throws<ArgumentException>(() =>
        {
            var _ = new Gs1ApplicationIdentifier(
                value,
                ".",
                "."
            );
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(value), ex.ParamName);
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
}