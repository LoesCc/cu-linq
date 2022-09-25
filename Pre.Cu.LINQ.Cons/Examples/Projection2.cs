using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class Projection2 : IExercise
{
    public void Run()
    {
        var names = new[] { "Tom", "Dick", "Harry", "Mary", "Jay" }.AsQueryable();

        // extension mehods
        var temp =
            names
                .Select(n => new TempProjectionItem
                    {
                        Original = n,
                        Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "")
                            .Replace("u", "")
                    }
                );
        temp.Dump();

        // query syntax
        var temp2 =
            names.Select(n => new TempProjectionItem
            {
                Original = n,
                Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
            });
        temp2.Dump();
    }

    class TempProjectionItem
    {
        public string Original; // Original name
        public string Vowelless; // Vowel-stripped name
    }
}