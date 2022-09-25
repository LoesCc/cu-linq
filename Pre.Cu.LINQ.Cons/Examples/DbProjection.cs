using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class DbProjection : IExercise
{
    private readonly LinqExerciseContext _dbContext;

    public DbProjection(LinqExerciseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Run()
    {
        // projection
        _dbContext.Products.Where(p => p.Category.Name == "Beverages")
            .Select(p => new
                {
                    Name = p.Name,
                    Price = p.UnitPrice
                }
            ).Dump();
    }
}