using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class SubQueries : IExercise
{
    public void Run()
    {
        string[] musos = { "Roger Waters", "David Gilmour", "Rick Wright", "Nick Mason" };
        musos.OrderBy(m => m.Split().Last())
            .Dump("Sorted by last name"); // each musician name gets splitted, lastname is kept --> subquery
    }
}