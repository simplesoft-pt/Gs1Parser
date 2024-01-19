using System.Text;

namespace SimpleSoft.Gs1Parser;

internal class Gs1 : Dictionary<string, Gs1ApplicationIdentifier>, IGs1
{
    private string _toString;


    public Gs1(string rawValue, char? separator) : base(StringComparer.OrdinalIgnoreCase)
    {
        rawValue.NotNull(nameof(rawValue));
        rawValue.NotNullOrWhiteSpace(nameof(rawValue));

        RawValue = rawValue;

        this.Separator = separator.Value;
    }

    public string RawValue { get; }
    private char Separator { get; }

    public override string ToString()
    {
        if (_toString is null)
        {
            var sb = new StringBuilder();
            foreach (var value in Values) 
                sb.Append(value).Append(this.Separator);
            _toString = sb.ToString();
        }

        return _toString;
    }
}