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
        var products = _dbContext.Products;
        // products.Dump("all products");
        var customers = _dbContext.Customers;
        // customers.Dump("all customers");
        var employees = _dbContext.Employees;
        // employees.Dump("all employees");

        /* Toon de productnamen waarvan we minder dan 20 UnitsInStock tellen, toon ook de bijbehorende categorienaam */
        products.Where(p => p.UnitsInStock < 20).Select(p => new { p.Name, p.UnitsInStock, p.Category }).Dump("Minder dan 20 units in stock");

        /* Toon de namen van de klanten waar in de ContactTitle het woord "sales" (hoofdletterongevoelig) voorkomt en die afkomstig zijn uit UK */
        customers.Where(c => c.Contact.Title.ToLower().Contains("sales") && c.Address.Country == "UK").Select(c => c.Name).Dump("Sales uit UK");

        /* Toon de namen van de klanten waar in de ContactTitle het woord "sales" (hoofdletterongevoelig) voorkomt en die afkomstig zijn uit
	     	   UK, Germany of Brazil*/
        List<string> allowedCountries = new List<string>() { "UK", "Germany", "Brazil" };
        customers.Where(c => c.Contact.Title.ToLower().Contains("sales") && allowedCountries.Contains(c.Address.Country)).Select(c => c.Name).Dump("Sales uit UK/Duitsland/Brazilië");

        /* Geef voor elke werknemer die een overste heeft (reportsto is ingevuld)
	        de voornaam en familienaam weer alsook hoeveel orders ze hebben behandeld in het meest recente jaar */
        employees.AsEnumerable()
            .Where(e => !string.IsNullOrWhiteSpace(e.ReportsTo))
            .Select(e => new {
                e.FirstName,
                e.LastName,
                AmountOfOrdersTotal = e.Orders.Count,
                LastYear = e.Orders.Count == 0 ? 0 : e.Orders.Max(o => o.OrderedDate.Year),
                AmountOfOrdersLastYear = e.Orders.Count(o => o.OrderedDate.Year == (e.Orders.Count == 0 ? 0 : e.Orders.Max(o => o.OrderedDate.Year)))
            })
            .Dump("Werknemers met overste: aantal orders");

        /*  Toon de eerste letter en het aantal ProductNames dat met deze letter begint.
            We zien enkel de letters waarvoor er minstens 2 producten zijn. */
        products.AsEnumerable()
            .GroupBy(p => p.Name.ToLower().First())
            .Select(group => new { FirstLetter = group.Key, Amount = group.Count() })
            .Where(group => group.Amount >= 2)
            .OrderBy(p => p.FirstLetter)
            .Dump("Eerste letter producten waarvan minstens 2 producten");
    }
}
