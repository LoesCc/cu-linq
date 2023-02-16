using Pre.Cu.LINQ.Core.Domain;

namespace Pre.Cu.LINQ.Core.Factories;

public class ProductFactory : IProductFactory
{
    public ProductFactory()
    {
    }

    public IEnumerable<Product> CreateDefaults(IEnumerable<Category> categories)
    {
        return new List<Product>()
        {
            new Product(1, "Chai", 1, categories.Single(c => c.Id == 1), "10 boxes x 20 bags", 18.00M, 39, 0),
            new Product(2, "Chang", 1, categories.Single(c => c.Id == 1), "24 - 12 oz bottles", 19.00M, 17, 40),
            new Product(3, "Aniseed Syrup", 1, categories.Single(c => c.Id == 2), "12 - 550 ml bottles", 10.00M, 13,
                70),
            new Product(4, "Chef Anton's Cajun Seasoning", 2, categories.Single(c => c.Id == 2), "48 - 6 oz jars",
                22.00M,
                53, 0),
            new Product(5, "Chef Anton's Gumbo Mix", 2, categories.Single(c => c.Id == 2), "36 boxes", 21.35M, 0, 0),
            new Product(6, "Grandma's Boysenberry Spread", 3, categories.Single(c => c.Id == 2), "12 - 8 oz jars",
                25.00M,
                120, 0),
            new Product(7, "Uncle Bob's Organic Dried Pears", 3, categories.Single(c => c.Id == 7), "12 - 1 lb pkgs.",
                30.00M, 15, 0),
            new Product(8, "Northwoods Cranberry Sauce", 3, categories.Single(c => c.Id == 2), "12 - 12 oz jars",
                40.00M, 6,
                0),
            new Product(9, "Mishi Kobe Niku", 4, categories.Single(c => c.Id == 6), "18 - 500 g pkgs.", 97.00M, 29, 0),
            new Product(10, "Ikura", 4, categories.Single(c => c.Id == 8), "12 - 200 ml jars", 31.00M, 31, 0),
            new Product(11, "Queso Cabrales", 5, categories.Single(c => c.Id == 4), "1 kg pkg.", 21.00M, 22, 30),
            new Product(12, "Queso Manchego La Pastora", 5, categories.Single(c => c.Id == 4), "10 - 500 g pkgs.",
                38.00M,
                86, 0),
            new Product(13, "Konbu", 6, categories.Single(c => c.Id == 8), "2 kg box", 6.00M, 24, 0),
            new Product(14, "Tofu", 6, categories.Single(c => c.Id == 7), "40 - 100 g pkgs.", 23.25M, 35, 0),
            new Product(15, "Genen Shouyu", 6, categories.Single(c => c.Id == 2), "24 - 250 ml bottles", 15.50M, 39, 0),
            new Product(16, "Pavlova", 7, categories.Single(c => c.Id == 3), "32 - 500 g boxes", 17.45M, 29, 0),
            new Product(17, "Alice Mutton", 7, categories.Single(c => c.Id == 6), "20 - 1 kg tins", 39.00M, 0, 0),
            new Product(18, "Carnarvon Tigers", 7, categories.Single(c => c.Id == 8), "16 kg pkg.", 62.50M, 42, 0),
            new Product(19, "Teatime Chocolate Biscuits", 8, categories.Single(c => c.Id == 3), "10 boxes x 12 pieces",
                9.20M, 25, 0),
            new Product(20, "Sir Rodney's Marmalade", 8, categories.Single(c => c.Id == 3), "30 gift boxes", 81.00M, 40,
                0)
        };
    }

    public IEnumerable<Product> CreateDefaults()
    {
        throw new NotImplementedException();
    }
}