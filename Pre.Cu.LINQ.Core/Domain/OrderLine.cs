using System.ComponentModel.DataAnnotations;

namespace Pre.Cu.LINQ.Core.Domain;

public class OrderLine
{
    public OrderLine()
    {
    }

    public OrderLine(int orderId, Product product, decimal pricePerUnit, int quantity, decimal discount)
    {
        OrderId = orderId;
        Product = product;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
        Discount = discount;
        ProductId = product.Id;
    }

    public int OrderId { get; set; }
    public int ProductId { get; set; }

    public Product Product { get; set; }
    public decimal PricePerUnit { get; set; }
    public int Quantity { get; set; }
    public decimal Discount { get; set; }
}