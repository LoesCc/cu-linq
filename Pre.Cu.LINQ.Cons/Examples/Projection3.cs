using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class Projection3 : IExercise
{
    private readonly LinqExerciseContext _dbContext;

    public Projection3(LinqExerciseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Run()
    {
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

        // 1
        // extension methods
        var query = names
            .Where(n => n.Contains("a"))
            .OrderBy(n => n.Length)
            .Select(n => n.ToUpper());

        query.Dump("names containing a");

        // query syntax
        var query2 = from n in names
            where n.Contains("a")
            orderby n.Length
            select n.ToUpper();

        query2.Dump("names containing a");

        // 2
        // extension methods and lambda expressions
        _dbContext.Customers.Where(c => c.Id.StartsWith("A")).Dump("Customers starting with A");

        // query syntax
        var customers = _dbContext.Customers.Where(c => c.Id.StartsWith("A"));
        
        customers.Dump("Customers starting with A");
    }
}