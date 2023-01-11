namespace SimpleSoft.Gs1Parser;

internal static class HelperExtensions
{
    /// <summary>
    /// Ensures the given value is not null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value"></param>
    /// <param name="paramName"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public static void NotNull<T>(this T value, string paramName) where T : class
    {
        if (value == null) 
            throw new ArgumentNullException(paramName);
    }

    /// <summary>
    /// Ensures the given string is not null or whitespace.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="paramName"></param>
    /// <exception cref="ArgumentException"></exception>
    public static void NotNullOrWhiteSpace(this string value, string paramName)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Value cannot be null or whitespace.", paramName);
    }
}