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
        /* TODO 1. Toon de productnamen waarvan we minder dan 20 UnitsInStock tellen, toon ook de bijbehorende categorienaam */

        /* TODO 2. Toon de namen van de klanten waar in de ContactTitle het woord "sales" voorkomt en afkomstig zijn uit Sweden */

        /* TODO 3. Toon de namen van de klanten waar in de ContactTitle het woord "sales" voorkomt en afkomstig zijn uit Italië, Frankrijk of Portugal*/

       
        /* TODO	4. Geef voor elke werknemer die een overste heeft (reportsto is ingevuld)
	        de voornaam en familienaam weer alsook hoeveel orders ze hebben behandeld in het meest recente jaar */

        

        /*  TODO 5. Toon de eerste letter en het aantal ProductNames dat met deze letter begint.
            We zien enkel de letters waarvoor er meer dan 2 producten zijn. */
        
    }
}
