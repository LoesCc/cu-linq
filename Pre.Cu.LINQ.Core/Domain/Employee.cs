namespace Pre.Cu.LINQ.Core.Domain;

public class Employee
{
    public Employee()
    {
        Orders = new List<Order>();
    }

    public Employee(int id, string lastName, string firstName, string title, string titleOfCourtesy, DateTime birthday,
        DateTime hireDate, Address address, string homePhone, string extension, string reportsTo, string notes) : this()
    {
        Id = id;
        LastName = lastName;
        FirstName = firstName;
        Title = title;
        TitleOfCourtesy = titleOfCourtesy;
        Birthday = birthday;
        HireDate = hireDate;
        Address = address;
        HomePhone = homePhone;
        Extension = extension;
        ReportsTo = reportsTo;
        Notes = notes;
    }

    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Title { get; set; }
    public string TitleOfCourtesy { get; }
    public Address Address { get; set; }
    public DateTime Birthday { get; set; }
    public DateTime HireDate { get; }
    public string HomePhone { get; set; }
    public string Extension { get; set; }
    public string ReportsTo { get; set; }
    public string Notes { get; set; }

    public List<Order> Orders { get; set; }

    protected bool Equals(Employee other)
    {
        return Id == other.Id;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Employee)obj);
    }

    public override int GetHashCode()
    {
        return Id;
    }
}
