using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Printing;
using System.Reflection.PortableExecutable;

namespace Pre.Cu.LINQ.Cons;

public class ExerciseA : IExercise
{
    public void Run()
    {
        List<int> numbers = new List<int> { 20, 35, 17, 105, 90 };
        numbers.Dump("All numbers in the list");

        // TODO 1. Getallen deelbaar door 5
        IEnumerable<int> dividableByFive = numbers
            .Where(n => n % 5 == 0)
            .Dump("Getallen deelbaar door 5.");

        // TODO 2. grootste getal
        int biggestNumber = numbers
            .Max()
            .Dump("Grootste getal");

        // TODO 3. voorlaatste getal
        int secondToLastNumber = numbers
            .SkipLast(1)
            .Last()
            .Dump("Voorlaatste getal");

        List<string> games = new List<string> { "Dominion", "Manillen", "Schaken", "Kolonisten van Catan", "Cluedo" };
        games.Dump("All games in the list.");

        // TODO 4. Uit hoeveel letters bestaan alle spellen samen (spaties niet meetellen)?
        int amountOfLetters = games
            .Select(g => g.Count(character => character != ' '))
            .Sum()
            .Dump("Aantal letters in alle spellen samen");

        // TODO 5. koppel de nummers aan de spellen: nummer is prijs van spel op dezelfde positie
        IEnumerable<string> coupledInfo = games
            .Zip(numbers, (a, b) => $"{a} kost EUR {b}")
            .Dump("Gekoppelde info");
    }
}
