using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class Expression : IExercise
{
    public void Run()
    {
        // "Where" is an extension method in System.Linq.Enumerable:

        var enumerableExample = (new[] { "Tom", "Dick", "Harry" }).Where(n => n.Length >= 4);
        Console.WriteLine(enumerableExample.GetType());
    }
}