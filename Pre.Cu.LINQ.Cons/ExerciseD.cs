using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons;

public class ExerciseD : IExercise
{
    private readonly LinqExerciseContext _dbContext;

    public ExerciseD(LinqExerciseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Run()
    {
        /* 1. Toon de productnamen waarvan we minder dan 20 UnitsInStock tellen, toon ook de bijbehorende categorienaam */
        var lessThanTwenty = _dbContext.Products
            .Where(p => p.UnitsInStock < 20)
            .Select(p => new { p.Name, p.Category, p.UnitsInStock })
            .Dump("Minder dan 20 Units in Stock.");

        /* 2. Toon de namen van de klanten waar in de ContactTitle het woord "sales" (hoofdletterongevoelig) voorkomt en die afkomstig zijn uit UK */
        var salesPeopleUK = _dbContext.Customers
            .Where(c => c.Contact.Title.ToLower().Contains("sales"))
            .Where(c => c.Address.Country == "UK")
            .Dump("Salespeople van de UK.");

        /* 3. Toon de namen van de klanten waar in de ContactTitle het woord "sales" (hoofdletterongevoelig) voorkomt en die afkomstig zijn uit
	     	   UK, Germany of Brazil*/
        List<string> countries = new List<string>() { "UK", "Germany", "Brazil" };

        var salesPeopleWorld = _dbContext.Customers
            .Where(c => c.Contact.Title.ToLower().Contains("sales"))
            .Where(c => countries.Contains(c.Address.Country))
            .Dump("Salespeople van de wereld.");

        /* 4. Geef voor elke werknemer die een overste heeft (reportsto is ingevuld)
	        de voornaam en familienaam weer alsook hoeveel orders ze hebben behandeld in het meest recente jaar */
        var employeeInfo = _dbContext.Employees
            .Where(e => e.ReportsTo != string.Empty)
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                AmountOfOrders = e.Orders.Count(),
                AmountOfOrdersThisYear = e.Orders.Count(o => o.OrderedDate.Year == DateTime.Now.Year)
            })
            .Dump("Werknemers met overste: info");

        /* 5. Toon de eerste letter en het aantal ProductNames dat met deze letter begint.
            We zien enkel de letters waarvoor er minstens 2 producten zijn. */
        var productNames = _dbContext.Products
            .GroupBy(p => p.Name.ToLower()[0])
            .Select(group => new
            {
                FirstLetter = group.Key,
                Amount = group.Count()
            })
            .Where(group => group.Amount >= 2)
            .Dump("Productnamen: eerste letter");
    }
}
