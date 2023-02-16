namespace Pre.Cu.LINQ.Core.Domain;

public class Customer
{
    public Customer()
    {
    }

    public Customer(string id, string name, string phone, string fax, Contact contact,
        Address address)
    {
        Id = id;
        Name = name;
        Phone = phone;
        Fax = fax;
        Contact = contact;
        Address = address;
    }

    public string Id { get; set; }

    public string Name { get; set; }
    public Contact Contact { get; set; }
    public Address Address { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
}