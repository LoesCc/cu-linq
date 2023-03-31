namespace Pre.Cu.LINQ.Core.Domain;

public class Order
{
    private readonly DateTime _requireAt;

    public Order()
    {
    }

    public Order(int id, Customer customer, Employee employee, DateTime orderedDate, DateTime requireDate,
        DateTime shippedDate, Address shipTo, int shipVia, decimal freight)
    {
        OrderDetails = new List<OrderLine>();
        Id = id;
        Customer = customer;
        Employee = employee;
        OrderedDate = orderedDate;
        RequireDate = requireDate;
        ShippedDate = shippedDate;
        ShipTo = shipTo;
        ShipVia = shipVia;
        Freight = freight;
    }

    public int Id { get; set; }
    public Customer Customer { get; set; }
    public Employee Employee { get; set; }
    public DateTime OrderedDate { get; set; }
    public DateTime ShippedDate { get; set; }
    public DateTime RequireDate { get; set; }
    public Address ShipTo { get; set; }
    public int ShipVia { get; set; }
    public decimal Freight { get; set; }

    public List<OrderLine> OrderDetails { get; set; }
}