using Pre.Cu.LINQ.Core.Domain;

namespace Pre.Cu.LINQ.Core;

public interface IOrderFactory : IFactory<Order>
{
    IEnumerable<Order> CreateDefaults(IEnumerable<Employee> employees, IEnumerable<Customer> customers);
    IEnumerable<OrderLine> CreateOrderLine(IEnumerable<Order> orders, IEnumerable<Product> products);
}