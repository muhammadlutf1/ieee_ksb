var customer = new Customer("Ahmed", new Address("Cairo"));
var customerShallow = customer.ShallowCopy();
var customerDeep = customer.DeepCopy();

customer.Address.City = "Alexandria";
Console.WriteLine($"Original: {customer.Address.City}");
Console.WriteLine($"Shallow: {customerShallow.Address.City}");
Console.WriteLine($"Deep: {customerDeep.Address.City}");

// `customerShallow` stores the same reference as `customer`
// so both points to the same data in the heap 
// so a change in any of both is actually changing the same data both points to

// `customerDeep` stores a different reference than `customer`
// so both point to different locations in the heap
// and both locations stores the same data (deep copy) but are totally independent


public class Address
{
    public string City;

    public Address(string city)
    {
        City = city;
    }
}

public class Customer
{
    public string Name;
    public Address Address;

    public Customer(string name, Address address)
    {
        Name = name;;
        Address = address;
    }

    public Customer ShallowCopy()
    {
        return (Customer)MemberwiseClone();
    }

    public Customer DeepCopy()
    {
        return new Customer(this.Name, new Address(this.Address.City));
    }
}