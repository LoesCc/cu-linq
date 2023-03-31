using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class DbQueries : IExercise
{
    private readonly LinqExerciseContext _dbContext;

    public DbQueries(LinqExerciseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Run()
    {
        // realy simple
        _dbContext.Categories.Dump("Categories");

        // Linq and lambda expressions
        _dbContext.Customers.Where(c => c.Id.StartsWith("A")).Dump("Customers starting with A");
        _dbContext.Products.Where(p => p.Category.Name == "Beverages").Dump("Beverages");

        // using variables
        string customerId = "BLONP";
        _dbContext.Orders
            .Where(o => o.Customer.Id == customerId).Dump($"{customerId}'s Orders")
            .Count().Dump($"#{customerId}'s Orders");

        int categoryID = 1;
        _dbContext.Products
            .Where(p => p.Category.Id == categoryID).Dump($"Products of Category {categoryID}")
            .Sum(p => p.UnitPrice).Dump($"Total Price for products of Category {categoryID}");
    }
}