using Pre.Cu.LINQ.Core.Domain;

namespace Pre.Cu.LINQ.Core;

public class DataSeeder : ISeeder
{
    private readonly LinqExerciseContext _dbContext;
    private readonly ICategoryFactory _categoryFactory;
    private readonly ICustomerFactory _customerFactory;
    private readonly IEmployeeFactory _employeeFactory;
    private readonly IProductFactory _productFactory;
    private readonly IOrderFactory _orderFactory;
    private readonly IPokemonFactory _pokemonFactory;

    public DataSeeder(LinqExerciseContext dbContext, ICategoryFactory categoryFactory, ICustomerFactory customerFactory,
        IEmployeeFactory employeeFactory, IProductFactory productFactory, IOrderFactory orderFactory,
        IPokemonFactory pokemonFactory)
    {
        _dbContext = dbContext;
        _categoryFactory = categoryFactory;
        _customerFactory = customerFactory;
        _employeeFactory = employeeFactory;
        _productFactory = productFactory;
        _orderFactory = orderFactory;
        _pokemonFactory = pokemonFactory;
    }


    public void Seed()
    {
        _dbContext.Categories.AddRange(_categoryFactory.CreateDefaults());
        _dbContext.SaveChanges();
        _dbContext.Customers.AddRange(_customerFactory.CreateDefaults());
        _dbContext.SaveChanges();
        _dbContext.Products.AddRange(_productFactory.CreateDefaults(_dbContext.Categories));
        _dbContext.SaveChanges();
        _dbContext.Employees.AddRange(_employeeFactory.CreateDefaults());
        _dbContext.SaveChanges();

        var orders = _orderFactory.CreateDefaults(_dbContext.Employees, _dbContext.Customers);
        _orderFactory.CreateOrderLine(orders, _dbContext.Products);
        _dbContext.Orders.AddRange(orders);
        _dbContext.Employees.ToList().ForEach(e => e.Orders.AddRange(orders.ToList().FindAll(o => o.Employee.Id == e.Id)));
        _dbContext.SaveChanges();

        _dbContext.Pokemon.AddRange(_pokemonFactory.CreateDefaults());
        _dbContext.SaveChanges();
    }
}