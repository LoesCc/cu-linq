namespace Pre.Cu.LINQ.Core.Domain;

public class Product
{
    public Product()
    {
    }

    public Product(int id, string name, int supplierId, Category category, string quantityPerUnit, decimal unitPrice,
        int unitsInStock, int unitsOnOrder)
    {
        Id = id;
        Name = name;
        SupplierId = supplierId;
        Category = category;
        QuantityPerUnit = quantityPerUnit;
        UnitPrice = unitPrice;
        UnitsInStock = unitsInStock;
        UnitsOnOrder = unitsOnOrder;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int SupplierId { get; set; }
    public Category Category { get; set; }
    public string QuantityPerUnit { get; set; }
    public int UnitsInStock { get; set; }
    public int UnitsOnOrder { get; set; }
    public bool Discontinued { get; set; }
    public int ReorderLevel { get; set; }
    public decimal UnitPrice { get; set; }
}