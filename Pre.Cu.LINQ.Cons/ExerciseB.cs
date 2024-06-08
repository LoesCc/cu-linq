using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Printing;

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

        students.Dump("Alle studenten");

        // Studenten waarbij voor en familienaam start met dezelfde letter
        IEnumerable<Student> sameFirstLetter = students.Where(s => s.FirstName.First() == s.LastName.First()).Dump("Zelfde eerste letter");

        // Gemiddelde leeftijd van de vrouwelijke studenten
        double meanAgeWomen = students.Where(s => s.Sex == "F").Average(s => s.Age).Dump("Gemiddelde leeftijd vrouwelijke studenten");

        // Student met grootste code gevormd door id^2 + 5, toon ook de code
        var specialCode = students.Select(s => new { Student = $"{s.FirstName} {s.LastName}", SpecialCode = Math.Pow(s.Id, 2) + 5 }).MaxBy(n => n.SpecialCode).Dump("Speciale code");
        
    }
}
