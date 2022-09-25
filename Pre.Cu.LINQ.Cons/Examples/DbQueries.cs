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

        // extension methods and lambda expressions
        _dbContext.Customers.Where(c => c.Id.StartsWith("A")).Dump("Customers starting with A");

        // using variables
        string customerId = "Alfki";
        _dbContext.Orders
            .Where(o => o.Customer.Id == customerId).Dump($"{customerId}'s Orders")
            .Count().Dump($"#{customerId}'s Orders");

        int categoryID = 1;
        _dbContext.Products
            .Where(p => p.Category.Id == categoryID).Dump($"Products of Catogry {categoryID}")
            .Sum(p => p.UnitPrice).Dump($"Total Price for products of Catogry {categoryID}");

        // with DataContext variable, easier to copy/paste to Visual Studio

        _dbContext.Products.Where(p => p.Category.Name == "Beverages").Dump();
    }
}