using Pre.Cu.LINQ.Core.Domain;

namespace Pre.Cu.LINQ.Core;

public interface IOrderFactory : IFactory<Order>
{
    List<Order> CreateDefaults(List<Employee> employees, List<Customer> customers);
    List<OrderLine> CreateOrderLine(List<Order> orders, List<Product> products);
}