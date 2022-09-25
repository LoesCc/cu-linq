namespace Pre.Cu.LINQ.Core.Domain;

public class Contact
{
    public Contact()
    {
        
    }
    public Contact(string name, string title)
    {
        Id = Guid.NewGuid();
        Name = name;
        Title = title;
    }

    public Guid Id { get; set; }

    public string Name { get; set; }
    public string Title { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Title})";
    }
}