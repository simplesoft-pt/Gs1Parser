using System.Reflection;

namespace SimpleSoft.Gs1Parser;

public class Gs1ApplicationIdentifierTypeTests
{
    [Fact]
    public void Constants_UniqueValue()
    {
        var constantFields = typeof(Gs1ApplicationIdentifierType).GetFields(
            BindingFlags.Public | BindingFlags.Static
        ).Where(f => f is
        {
            IsLiteral: true,
            IsInitOnly: false
        }).GroupBy(f => f.GetRawConstantValue() as string).Select(g => new
        {
            Value = g.Key,
            Total = g.Count()
        }).Where(g => g.Total > 1);

        Assert.Empty(constantFields);
    }
}