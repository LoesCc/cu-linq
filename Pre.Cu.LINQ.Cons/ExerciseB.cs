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

        // TODO 1. Studenten waarbij voor en familienaam start met dezelfde letter

        // TODO 2. Gemiddelde leeftijd van de vrouwelijke studenten
        
        // TODO 3. Student met grootste code gevormd door id^2 + 5, toon ook de code
        
    }
}
