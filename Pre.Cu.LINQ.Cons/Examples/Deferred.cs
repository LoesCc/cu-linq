using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class Deferred : IExercise
{
    public void Run()
    {
        // example with names
        List<string> names = new List<string> { "Olivier", "Frédéric", "William" };
        var listOfNames = names.Where(n => n.Contains("e"));
        // do stuff
        names.Add("Hendrik");
        listOfNames.Dump("Hendrik got sneaked in!");

        // reevalutaion: linq query reexecutes each time you iterate
        var numbers = new List<int>() { 1, 2 };
        var query = numbers.Select(n => n * 10);
        query.Dump("Both elements are returned");
        numbers.Clear();
        query.Dump("All the elements are now gone!");

        // reavalution - keep results
        numbers = new List<int>() { 1, 2 };
        List<int> timesTen = numbers
            .Select(n => n * 10)
            .ToList(); // Executes immediately into a List<int> in variable timesTen
        numbers.Clear();
        timesTen.Count.Dump("timesTen has 2 elements");
        numbers.Dump("numbers is empty");
    }
}