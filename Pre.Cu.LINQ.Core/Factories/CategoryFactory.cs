using Microsoft.EntityFrameworkCore;
using Pre.Cu.LINQ.Core.Domain;

namespace Pre.Cu.LINQ.Core.Factories;

public class CategoryFactory : ICategoryFactory
{
    private readonly LinqExerciseContext _exerciseDbContext;

    public CategoryFactory(LinqExerciseContext exerciseDbContext)
    {
        _exerciseDbContext = exerciseDbContext;
    }

    public IEnumerable<Category> CreateDefaults()
    {
        return new List<Category>()
        {
            new Category(1, "Beverages", "Soft drinks, coffees, teas, beers, and ales"),
            new Category(2, "Condiments", "Sweet and savory sauces, relishes, spreads, and seasonings"),
            new Category(3, "Confections", "Desserts, candies, and sweet breads"),
            new Category(4, "Dairy Products", "Cheeses"),
            new Category(5, "Grains/Cereals", "Breads, crackers, pasta, and cereal"),
            new Category(6, "Meat/Poultry", "Prepared meats"),
            new Category(7, "Produce", "Dried fruit and bean curd"),
            new Category(8, "Seafood", "Seaweed and fish")
        };
    }
}