using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class DbGrouping : IExercise
{
    private readonly LinqExerciseContext _dbContext;

    public DbGrouping(LinqExerciseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Run()
    {
        // Group by - Products by category
        _dbContext.Products
            .GroupBy(prod => prod.Category.Id)
            .Select(grouping => new { grouping.Key, Products = grouping.ToList() })
            .Dump("Group by: products by category");


        // Group by - Max product price per category
        _dbContext.Products
            .GroupBy(prod => prod.Category.Id)
            .Select(g => new
            {
                CategoryId = g.Key,
                MaxPrice = g.Max(p => p.UnitPrice),
            })
            .Dump("Group by: max price per category");


        // Grouping on multiple columns
        _dbContext.Products
            .GroupBy(prod => new
            {
                prod.Category.Id,
                prod.Category.Name
            })
            .Select(g => new
            {
                CategoryId = g.Key.Id,
                CategoryName = g.Key.Name,
                MaxPrice = g.Max(p => p.UnitPrice),
            })
            .Dump("Group on multiple columns");
    }
}