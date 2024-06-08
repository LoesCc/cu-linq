using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons;

public class ExerciseA : IExercise
{
    public void Run()
    {
        List<int> numbers = new List<int> { 20, 35, 17, 105, 90 };
        numbers.Dump("Alle getallen (int)");
        
        // Getallen deelbaar door 5
        IEnumerable<int> numbersModuloFive = numbers.Where(n => n % 5 == 0).Dump("Getallen deelbaar door 5");

        // grootste getal
        int biggestNumber = numbers.Max().Dump("Grootste getal");

        // voorlaatste getal
        int secondToLastNumber = numbers.ElementAt(numbers.Count - 2).Dump("Voorlaatste getal");

        List<string> games = new List<string> { "Dominion", "Manillen", "Schaken", "Kolonisten van Catan", "Cluedo" };
        games.Dump("Alle games (string)");

        // Uit hoeveel letters bestaan alle spellen samen (spaties niet meetellen)?
        int amountOfLettersAllGames = games.Select(n => n.Replace(" ", "")).Sum(n => n.Length).Dump("Aantal letters in totaal");

        // koppel de nummers aan de spellen: nummer is prijs van spel op dezelfde positie
        IEnumerable<string> zipped = games.Zip(numbers, (g, n) => $"{g} kost EUR {n:0.00}").Dump("Spellen en prijzen");
    }
}
