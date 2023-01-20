
using System.Globalization;
#if !NET6_0_OR_GREATER
using DateOnly = System.DateTime;
#endif

namespace SimpleSoft.Gs1Parser;

/// <summary>
/// Extension methods for <see cref="Gs1ApplicationIdentifier"/> instances.
/// </summary>
public static class Gs1ApplicationIdentifierExtensions
{
    /// <summary>
    /// Tries to return the <see cref="Gs1ApplicationIdentifier.DataContent"/> as a long value.
    /// </summary>
    /// <param name="ai">The application identifier</param>
    /// <param name="dataContent">The long value, if converted successfully</param>
    /// <returns>true if converted successfully, otherwise false</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool TryGetDataContentAsLong(this Gs1ApplicationIdentifier ai, out long dataContent)
    {
        ai.NotNull(nameof(ai));

        return long.TryParse(
            ai.DataContent,
            NumberStyles.None,
            NumberFormatInfo.InvariantInfo,
            out dataContent
        );
    }

    /// <summary>
    /// Returns the <see cref="Gs1ApplicationIdentifier.DataContent"/> as a long value.
    /// </summary>
    /// <param name="ai">The application identifier</param>
    /// <returns>The long value</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="FormatException"></exception>
    public static long GetDataContentAsLong(this Gs1ApplicationIdentifier ai)
    {
        if(ai.TryGetDataContentAsLong(out var dataContent))
            return dataContent;
        throw new FormatException($"GS1 application identifier '{ai}' data content is not a valid long");
    }

    /// <summary>
    /// Tries to return the <see cref="Gs1ApplicationIdentifier.DataContent"/> as a int value.
    /// </summary>
    /// <param name="ai">The application identifier</param>
    /// <param name="dataContent">The int value, if converted successfully</param>
    /// <returns>true if converted successfully, otherwise false</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool TryGetDataContentAsInt(this Gs1ApplicationIdentifier ai, out int dataContent)
    {
        ai.NotNull(nameof(ai));

        return int.TryParse(
            ai.DataContent,
            NumberStyles.None,
            NumberFormatInfo.InvariantInfo,
            out dataContent
        );
    }

    /// <summary>
    /// Returns the <see cref="Gs1ApplicationIdentifier.DataContent"/> as a int value.
    /// </summary>
    /// <param name="ai">The application identifier</param>
    /// <returns>The int value</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="FormatException"></exception>
    public static int GetDataContentAsInt(this Gs1ApplicationIdentifier ai)
    {
        if(ai.TryGetDataContentAsInt(out var dataContent))
            return dataContent;
        throw new FormatException($"GS1 application identifier '{ai}' data content is not a valid int");
    }

    /// <summary>
    /// Tries to return the <see cref="Gs1ApplicationIdentifier.DataContent"/> as a date only value.
    /// </summary>
    /// <param name="ai">The application identifier</param>
    /// <param name="dataContent">The date value, if converted successfully</param>
    /// <returns>true if converted successfully, otherwise false</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool TryGetDataContentAsDate(this Gs1ApplicationIdentifier ai, out DateOnly dataContent)
    {
        if (ai.TryGetDataContentAsInt(out var dt) && dt is > 0 and < 999999)
        {
            var month = dt / 100 % 100;
            if (month is > 0 and < 13)
            {
                var year = dt / 10000 % 100;

                var currentYear = DateTime.Now.Year;
                var expectedYear = currentYear / 100 * 100 + year;

                expectedYear += (expectedYear - currentYear) switch
                {
                    >= 51 and <= 99 => -100,
                    <= -50 and >= -99 => 100,
                    _ => 0,
                };

                var day = dt % 100;
                var daysInMonth = DateTime.DaysInMonth(expectedYear, month);
                if (day <= daysInMonth)
                {
                    if (day == 0)
                        day = daysInMonth;

                    dataContent = new DateOnly(expectedYear, month, day);
                    return true;
                }
            }
        }

        dataContent = default;
        return false;
    }

    /// <summary>
    /// Returns the <see cref="Gs1ApplicationIdentifier.DataContent"/> as a date only value.
    /// </summary>
    /// <param name="ai">The application identifier</param>
    /// <returns>The date only value</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="FormatException"></exception>
    public static DateOnly GetDataContentAsDate(this Gs1ApplicationIdentifier ai)
    {
        if (ai.TryGetDataContentAsDate(out var dataContent))
            return dataContent;
        throw new FormatException($"GS1 application identifier '{ai}' data content is not a valid date");
    }

    /// <summary>
    /// Tries to return the <see cref="Gs1ApplicationIdentifier.DataContent"/> as a decimal value.
    /// </summary>
    /// <param name="ai">The application identifier</param>
    /// <param name="skip">Data content characters to skip, excluding decimal point</param>
    /// <param name="dataContent">The date value, if converted successfully</param>
    /// <returns>true if converted successfully, otherwise false</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool TryGetDataContentAsDecimal(this Gs1ApplicationIdentifier ai, int skip, out decimal dataContent)
    {
        ai.NotNull(nameof(ai));

        var idx = skip + 1;
        if (idx > 0 && ai.DataContent.Length > idx)
        {
            var decimalPointPosition = ai.DataContent[0];
            if (char.IsDigit(decimalPointPosition))
            {
                var decimalValue = (decimal) Math.Pow(10, decimalPointPosition - '0');
                if (long.TryParse(
                        ai.DataContent.Substring(idx),
                        NumberStyles.None,
                        NumberFormatInfo.InvariantInfo,
                        out var dt))
                {
                    dataContent = decimalValue > 0.0m ? dt / decimalValue : dt;
                    return true;
                }
            }
        }

        dataContent = default;
        return false;
    }

    /// <summary>
    /// Returns the <see cref="Gs1ApplicationIdentifier.DataContent"/> as a decimal value.
    /// </summary>
    /// <param name="ai">The application identifier</param>
    /// <param name="skip">Data content characters to skip, excluding decimal point</param>
    /// <returns>The date only value</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="FormatException"></exception>
    public static decimal GetDataContentAsDecimal(this Gs1ApplicationIdentifier ai, int skip)
    {
        if (ai.TryGetDataContentAsDecimal(skip, out var dataContent))
            return dataContent;
        throw new FormatException($"GS1 application identifier '{ai}' data content is not a valid decimal");
    }

    /// <summary>
    /// Tries to return the <see cref="Gs1ApplicationIdentifier.DataContent"/> as a decimal value.
    /// </summary>
    /// <param name="ai">The application identifier</param>
    /// <param name="dataContent">The date value, if converted successfully</param>
    /// <returns>true if converted successfully, otherwise false</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool TryGetDataContentAsDecimal(this Gs1ApplicationIdentifier ai, out decimal dataContent) =>
        ai.TryGetDataContentAsDecimal(0, out dataContent);

    /// <summary>
    /// Returns the <see cref="Gs1ApplicationIdentifier.DataContent"/> as a decimal value.
    /// </summary>
    /// <param name="ai">The application identifier</param>
    /// <returns>The date only value</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="FormatException"></exception>
    public static decimal GetDataContentAsDecimal(this Gs1ApplicationIdentifier ai) => ai.GetDataContentAsDecimal(0);
}