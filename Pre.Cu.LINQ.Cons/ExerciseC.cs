using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons;

public class ExerciseC : IExercise
{
    private readonly LinqExerciseContext _dbContext;

    public ExerciseC(LinqExerciseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Run()
    {
        // TODO 0. Dit is een voorbeeld van hoe je alle Pokemon weergeeft die terug te vinden zijn in je In-Memory databank
        _dbContext.Pokemon.ToList().Dump("List all pokemon");
        // TODO 1. Geef alle Pokemon weer die niet tot generatie 1, 2 of 4 behoren en legendary zijn 

        // TODO 2. Geef de Pokemon weer die behoren tot Gen II, behoren tot de category Fire, Psychic of Rock en hebben binnen hun categorie een attackbonus 
        // die hoger ligt dan het gemiddelde.
        // TODO 3. Geef de gemiddelde Hp, Attack en Defense weer voor de pokemon van Generation I per type

    }
}