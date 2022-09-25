using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class Projection1 : IExercise
{
    public void Run()
    {
        var names = new[] { "Tom", "Dick", "Harry", "Mary", "Jay" }.AsQueryable();
        // Lambda Syntax - Extension methods
        var query = names
            .Select(n => new
                {
                    Original = n,
                    Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
                }
            );
        query.Dump();


        // Query Syntax
        var query2 = from n in names
            select new
            {
                Original = n,
                Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
            };
        query2.Dump();
    }
}