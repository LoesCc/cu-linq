using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class Projection3 : IExercise
{

    public void Run()
    {
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

        var query = names
            .Where(n => n.EndsWith("y"))
            .OrderBy(n => n.Length)
            .Select(n => n.ToUpper());

        query.Dump("names ending with y");

    }
}