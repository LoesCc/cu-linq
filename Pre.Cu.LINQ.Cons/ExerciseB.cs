using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Printing;
using System.Linq;

namespace Pre.Cu.LINQ.Cons;

public class ExerciseB : IExercise
{
    public void Run()
    {
        var students = new List<Student>
        {
            new Student { Id = 1, FirstName = "Freddie", LastName = "Fish", Age = 18, Sex = "M" },
            new Student { Id = 2, FirstName = "Bill", LastName = "Jones", Age = 21, Sex = "M" },
            new Student { Id = 3, FirstName = "Kitty", LastName = "Cat", Age = 19, Sex = "F" },
            new Student { Id = 4, FirstName = "Suzy", LastName = "Wan", Age = 20, Sex = "F" }
        };

        // 1. Studenten waarbij voor en familienaam start met dezelfde letter
        IEnumerable<Student> sameFirstLetters = students
            .Where(s => s.FirstName.First() == s.LastName.First())
            .Dump("Eerste zelfde letters.");

        // 2. Gemiddelde leeftijd van de vrouwelijke studenten
        double meanAge = students
            .Where(s => s.Sex == "F")
            .Average(f => f.Age)
            .Dump("Gemiddelde leeftijd.");

        // 3. Student met grootste code gevormd door id^2 + 5, toon ook de code
        var studentBiggestCode = students
            .Select(s => new { s.Id, s.FirstName, Code = Math.Pow(s.Id, 2) + 5 })
            .MaxBy(n => n.Code)
            .Dump("Student met grootste code.");
        
    }
}
