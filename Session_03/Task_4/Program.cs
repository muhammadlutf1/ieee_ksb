var m1 = new Money(1200, "EGP");
var m2 = new Money(1200, "EGP");

Console.WriteLine(m1 == m2);
Console.WriteLine(ReferenceEquals(m1, m2));
Console.WriteLine(m1.GetHashCode()); 
Console.WriteLine(m2.GetHashCode()); // same as m1
Console.WriteLine("#################");
// records comparision uses values rather than references

var m3 = new Money2(100, "USD");
var m4 = new Money2(100, "USD");

Console.WriteLine(m3 == m4);
Console.WriteLine(ReferenceEquals(m3, m4));
Console.WriteLine(m3.GetHashCode());
Console.WriteLine(m4.GetHashCode()); // different
Console.WriteLine("#################");

var set = new HashSet<Money>();

set.Add(m1);
set.Add(m2);

// m1 and m2 has the same hashCode so only one copy of them will be present in the HashSet

Console.WriteLine(set.Count); // 1

var m5 = m1 with { Amount = 1250 };

set.Add(m5);

Console.WriteLine(set.Count); // 2


public record Money(decimal Amount, string Currency);

public class Money2(decimal amount, string currency)
{
    public decimal Amount { get; set; } = amount;
    public string Currency { get; set; } = currency;
};