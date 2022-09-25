namespace Pre.Cu.LINQ.Core.Domain;

public class Supplier
{
    public Guid Id { get; set; }
    public Contact Contact { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string HomePage { get; set; }
}