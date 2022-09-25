using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class Dump : IExercise
{
    public void Run()
    {
        // Working with Dump()
        123.Dump();
        string[] names = { "Olivier", "Frédéric", "William" };
        names.Dump();

        // Peek in complex type
        TimeZoneInfo.Local.Dump("Bet you never knew this type existed!");

        // Dump() to peak in chained methods
        new[] { 11, 5, 17, 7, 13 }.Dump("Prime numbers")
            .Where(n => n > 10).Dump("Prime numbers > 10")
            .OrderBy(n => n).Dump("Prime numbers > 10 sorted")
            .Select(n => n * 10).Dump("Prime numbers > 10 sorted, times 10!");
    }
}