using System.ComponentModel.DataAnnotations.Schema;

namespace Pre.Cu.LINQ.Core.Domain;

public class Address
{
    public Address()
    {
        Id = Guid.NewGuid();
    }

    public Address(string address, string city, string region, string postalCode, string country):this()
    {
        Line1 = address;
        City = city;
        Region = region;
        PostalCode = postalCode;
        Country = country;
    }

    public Guid Id { get; set; }
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }

    public override string ToString()
    {
        return $"{Line1}, {PostalCode} {City},{Country}";
    }
}