using System.Xml.Linq;

namespace Library.Domain.ValueObjects;

public class ISBN
{
    public string Value { get; set; }

    public ISBN(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentNullException("Value cannot be empty.");

        Value = value;  
    }

    public override bool Equals(object obj)
    {
        if (obj is not ISBN other) return false;        
        return Value == other.Value;
    }

    public override int GetHashCode() { return Value.GetHashCode(); }

    public override string ToString() { return Value; }
}
