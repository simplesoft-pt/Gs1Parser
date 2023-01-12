using System.Text;

namespace SimpleSoft.Gs1Parser;

internal class Gs1 : Dictionary<string, Gs1ApplicationIdentifier>, IGs1
{
    private string _toString;

    public Gs1(string rawValue) : base(StringComparer.OrdinalIgnoreCase)
    {
        rawValue.NotNull(nameof(rawValue));
        rawValue.NotNullOrWhiteSpace(nameof(rawValue));

        RawValue = rawValue;
    }

    public string RawValue { get; }

    public override string ToString()
    {
        if (_toString is null)
        {
            var sb = new StringBuilder();
            foreach (var value in Values) 
                sb.Append(value).Append(';');
            _toString = sb.ToString();
        }

        return _toString;
    }
}