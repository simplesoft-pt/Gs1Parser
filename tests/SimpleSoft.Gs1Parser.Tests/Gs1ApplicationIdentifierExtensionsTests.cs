using System.Globalization;

namespace SimpleSoft.Gs1Parser;

public class Gs1ApplicationIdentifierExtensionsTests
{
    #region AsLong

    [Fact]
    public void AsLong_TryGetDataContent_NullValue_ArgumentNullException()
    {
        Gs1ApplicationIdentifier? ai = null;
        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            ai.TryGetDataContentAsLong(out _);
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(ai), ex.ParamName);
    }

    [Fact]
    public void AsLong_GetDataContent_NullValue_ArgumentNullException()
    {
        Gs1ApplicationIdentifier? ai = null;
        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            ai.GetDataContentAsLong();
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(ai), ex.ParamName);
    }

    [Fact]
    public void AsLong_TryGetDataContent_Valid_ReturnsTrue_OutputMatches()
    {
        const long dataContent = 123L;

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("D", NumberFormatInfo.InvariantInfo)
        );

        var parsed = ai.TryGetDataContentAsLong(out var parsedDataContent);

        Assert.True(parsed);
        Assert.Equal(dataContent, parsedDataContent);
    }

    [Fact]
    public void AsLong_GetDataContent_Valid_OutputMatches()
    {
        const long dataContent = 123L;

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("D", NumberFormatInfo.InvariantInfo)
        );

        var parsedDataContent = ai.GetDataContentAsLong();
        
        Assert.Equal(dataContent, parsedDataContent);
    }

    [Theory]
    [InlineData("-15000")]
    [InlineData(" 15000")]
    [InlineData("15000 ")]
    [InlineData("15.000")]
    public void AsLong_TryGetDataContent_Invalid_ReturnsFalse(string dataContent)
    {
        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent
        );

        var parsed = ai.TryGetDataContentAsLong(out var parsedDataContent);

        Assert.False(parsed);
        Assert.Equal(default, parsedDataContent);
    }

    [Theory]
    [InlineData("-15000")]
    [InlineData(" 15000")]
    [InlineData("15000 ")]
    [InlineData("15.000")]
    public void AsLong_GetDataContent_Invalid_FormatException(string dataContent)
    {
        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent
        );

        var ex = Assert.Throws<FormatException>(() =>
        {
            ai.GetDataContentAsLong();
        });

        Assert.Contains("data content is not a valid long", ex.Message);
    }

    #endregion

    #region AsInt

    [Fact]
    public void AsInt_TryGetDataContent_NullValue_ArgumentNullException()
    {
        Gs1ApplicationIdentifier? ai = null;
        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            ai.TryGetDataContentAsInt(out _);
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(ai), ex.ParamName);
    }

    [Fact]
    public void AsInt_GetDataContent_NullValue_ArgumentNullException()
    {
        Gs1ApplicationIdentifier? ai = null;
        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            ai.GetDataContentAsInt();
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(ai), ex.ParamName);
    }

    [Fact]
    public void AsInt_TryGetDataContent_Valid_ReturnsTrue_OutputMatches()
    {
        const int dataContent = 123;

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("D", NumberFormatInfo.InvariantInfo)
        );

        var parsed = ai.TryGetDataContentAsInt(out var parsedDataContent);

        Assert.True(parsed);
        Assert.Equal(dataContent, parsedDataContent);
    }

    [Fact]
    public void AsInt_GetDataContent_Valid_OutputMatches()
    {
        const int dataContent = 123;

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("D", NumberFormatInfo.InvariantInfo)
        );

        var parsedDataContent = ai.GetDataContentAsInt();
        
        Assert.Equal(dataContent, parsedDataContent);
    }

    [Theory]
    [InlineData("-15000")]
    [InlineData(" 15000")]
    [InlineData("15000 ")]
    [InlineData("15.000")]
    public void AsInt_TryGetDataContent_Invalid_ReturnsFalse(string dataContent)
    {
        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent
        );

        var parsed = ai.TryGetDataContentAsInt(out var parsedDataContent);

        Assert.False(parsed);
        Assert.Equal(default, parsedDataContent);
    }

    [Theory]
    [InlineData("-15000")]
    [InlineData(" 15000")]
    [InlineData("15000 ")]
    [InlineData("15.000")]
    public void AsInt_GetDataContent_Invalid_FormatException(string dataContent)
    {
        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent
        );

        var ex = Assert.Throws<FormatException>(() =>
        {
            ai.GetDataContentAsInt();
        });

        Assert.Contains("data content is not a valid int", ex.Message);
    }

    #endregion

    #region AsDate

    [Fact]
    public void AsDate_TryGetDataContent_NullValue_ArgumentNullException()
    {
        Gs1ApplicationIdentifier? ai = null;
        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            ai.TryGetDataContentAsDate(out _);
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(ai), ex.ParamName);
    }

    [Fact]
    public void AsDate_GetDataContent_NullValue_ArgumentNullException()
    {
        Gs1ApplicationIdentifier? ai = null;
        var ex = Assert.Throws<ArgumentNullException>(() =>
        {
            ai.GetDataContentAsDate();
        });

        Assert.NotNull(ex);
        Assert.Equal(nameof(ai), ex.ParamName);
    }

    [Fact]
    public void AsDate_TryGetDataContent_Valid_ReturnsTrue_OutputMatches()
    {
        var now = DateTime.Now;

        var dataContent = new DateOnly(now.Year, now.Month, now.Day);

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("yyMMdd", DateTimeFormatInfo.InvariantInfo)
        );

        var parsed = ai.TryGetDataContentAsDate(out var parsedDataContent);

        Assert.True(parsed);
        Assert.Equal(dataContent, parsedDataContent);
    }

    [Fact]
    public void AsDate_GetDataContent_Valid_OutputMatches()
    {
        var now = DateTime.Now;

        var dataContent = new DateOnly(now.Year, now.Month, now.Day);

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("yyMMdd", DateTimeFormatInfo.InvariantInfo)
        );

        var parsedDataContent = ai.GetDataContentAsDate();
        
        Assert.Equal(dataContent, parsedDataContent);
    }

    [Fact]
    public void AsDate_TryGetDataContent_Valid_Future50Years_ReturnsTrue_OutputMatches()
    {
        var now = DateTime.Now;

        var dataContent = new DateOnly(now.Year, now.Month, now.Day)
            .AddYears(50);

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("yyMMdd", DateTimeFormatInfo.InvariantInfo)
        );

        var parsed = ai.TryGetDataContentAsDate(out var parsedDataContent);

        Assert.True(parsed);
        Assert.Equal(dataContent, parsedDataContent);
    }

    [Fact]
    public void AsDate_GetDataContent_Valid_Past49Years_OutputMatches()
    {
        var now = DateTime.Now;

        var dataContent = new DateOnly(now.Year, now.Month, now.Day)
            .AddYears(-49);

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("yyMMdd", DateTimeFormatInfo.InvariantInfo)
        );

        var parsedDataContent = ai.GetDataContentAsDate();
        
        Assert.Equal(dataContent, parsedDataContent);
    }

    [Fact]
    public void AsDate_TryGetDataContent_Valid_Future51Years_ReturnsTrue_SubtractsCentury()
    {
        var now = DateTime.Now;

        var dataContent = new DateOnly(now.Year, now.Month, now.Day)
            .AddYears(51);

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("yyMMdd", DateTimeFormatInfo.InvariantInfo)
        );

        var parsed = ai.TryGetDataContentAsDate(out var parsedDataContent);

        Assert.True(parsed);
        Assert.Equal(dataContent.AddYears(-100), parsedDataContent);
    }

    [Fact]
    public void AsDate_GetDataContent_Valid_Past50Years_AddsCentury()
    {
        var now = DateTime.Now;

        var dataContent = new DateOnly(now.Year, now.Month, now.Day)
            .AddYears(-50);

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("yyMMdd", DateTimeFormatInfo.InvariantInfo)
        );

        var parsedDataContent = ai.GetDataContentAsDate();
        
        Assert.Equal(dataContent.AddYears(100), parsedDataContent);
    }

    [Fact]
    public void AsDate_TryGetDataContent_Valid_ZeroDays_ReturnsTrue_LastDayOfMonth()
    {
        var now = DateTime.Now;

        var dataContent = new DateOnly(
            now.Year,
            now.Month,
            DateTime.DaysInMonth(now.Year, now.Month)
        );

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("yyMM", DateTimeFormatInfo.InvariantInfo) + "00"
        );

        var parsed = ai.TryGetDataContentAsDate(out var parsedDataContent);

        Assert.True(parsed);
        Assert.Equal(dataContent, parsedDataContent);
    }

    [Fact]
    public void AsDate_GetDataContent_Valid_Past50Years_LastDayOfMonth()
    {
        var now = DateTime.Now;

        var dataContent = new DateOnly(
            now.Year,
            now.Month,
            DateTime.DaysInMonth(now.Year, now.Month)
        );

        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent.ToString("yyMM", DateTimeFormatInfo.InvariantInfo) + "00"
        );

        var parsedDataContent = ai.GetDataContentAsDate();
        
        Assert.Equal(dataContent, parsedDataContent);
    }

    [Theory]
    [InlineData("500015")]
    [InlineData("501315")]
    [InlineData("500132")]
    [InlineData(" 500615")]
    [InlineData("500615 ")]
    public void AsDate_TryGetDataContent_InvalidDataContent_ReturnsFalse(string dataContent)
    {
        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent
        );

        var parsed = ai.TryGetDataContentAsDate(out var parsedDataContent);

        Assert.False(parsed);
        Assert.Equal(default, parsedDataContent);
    }

    [Theory]
    [InlineData("500015")]
    [InlineData("501315")]
    [InlineData("500132")]
    [InlineData(" 500615")]
    [InlineData("500615 ")]
    public void AsDate_GetDataContent_InvalidDataContent_FormatException(string dataContent)
    {
        var ai = new Gs1ApplicationIdentifier(
            "x",
            "x",
            dataContent
        );

        var ex = Assert.Throws<FormatException>(() =>
        {
            ai.GetDataContentAsDate();
        });

        Assert.Contains("data content is not a valid date", ex.Message);
    }

    #endregion
}