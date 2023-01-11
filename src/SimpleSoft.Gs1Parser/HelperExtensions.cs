namespace SimpleSoft.Gs1Parser;

internal static class HelperExtensions
{
    /// <summary>
    /// Ensures the given value is not null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value"></param>
    /// <param name="paramName"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static T NotNull<T>(this T value, string paramName) where T : class
    {
        if (value == null) 
            throw new ArgumentNullException(paramName);
        return value;
    }

    /// <summary>
    /// Ensures the given string is not null or whitespace.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramName"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static string NotNullOrWhiteSpace(this string value, string paramName)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Value cannot be null or whitespace.", paramName);
        return value;
    }
}