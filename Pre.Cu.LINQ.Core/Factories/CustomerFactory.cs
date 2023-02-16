using Pre.Cu.LINQ.Core.Domain;

namespace Pre.Cu.LINQ.Core.Factories;

public class CustomerFactory : ICustomerFactory
{
    public CustomerFactory()
    {
    }

    public IEnumerable<Customer> CreateDefaults()
    {
        return new List<Customer>()
        {
            new Customer("ALFKI",
                "Alfreds Futterkiste",
                "030-0074321",
                "030-0076545",
                new Contact("Maria Anders", "Sales Representative"),
                new Address("Obere Str. 57", "Berlin", "", "12209", "Germany")),

            new Customer("ANATR", "Ana Trujillo Emparedados y helados", "(5) 555-4729", "(5) 555-3745",
                new Contact("Ana Trujillo", "Owner"),
                new Address("Avda. de la Constitución 2222", "México D.F.", "", "05021", "Mexico")),
            new Customer("ANTON", "Antonio Moreno Taquería", "(5) 555-3932", "", new Contact("Antonio Moreno", "Owner"),
                new Address("Mataderos  2312", "México D.F.", "", "05023", "Mexico")),
            new Customer("AROUT", "Around the Horn", "(171) 555-7788", "(171) 555-6750",
                new Contact("Thomas Hardy", "Sales Representative"),
                new Address("120 Hanover Sq.", "London", "", "WA1 1DP", "UK")),
            new Customer("BERGS", "Berglunds snabbköp", "0921-12 34 65", "0921-12 34 67",
                new Contact("Christina Berglund", "Order Administrator"),
                new Address("Berguvsvägen  8", "Luleå", "", "S-958 22", "Sweden")),
            new Customer("BLAUS", "Blauer See Delikatessen", "0621-08460", "0621-08924",
                new Contact("Hanna Moos", "Sales Representative"),
                new Address("Forsterstr. 57", "Mannheim", "", "68306", "Germany")),
            new Customer("BLONP", "Blondesddsl père et fils", "88.60.15.31", "88.60.15.32",
                new Contact("Frédérique Citeaux", "Marketing Manager"),
                new Address("24, place Kléber", "Strasbourg", "", "67000", "France")),
            new Customer("BOLID", "Bólido Comidas preparadas", "(91) 555 22 82", "(91) 555 91 99",
                new Contact("Martín Sommer", "Owner"), new Address("C/ Araquil, 67", "Madrid", "", "28023", "Spain")),
            new Customer("BONAP", "Bon app'", "91.24.45.40", "91.24.45.41", new Contact("Laurence Lebihan", "Owner"),
                new Address("12, rue des Bouchers", "Marseille", "", "13008", "France")),
            new Customer("BOTTM", "Bottom-Dollar Markets", "(604) 555-4729", "(604) 555-3745",
                new Contact("Elizabeth Lincoln", "Accounting Manager"),
                new Address("23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada")),
            new Customer("BSBEV", "B's Beverages", "(171) 555-1212", "",
                new Contact("Victoria Ashworth", "Sales Representative"),
                new Address("Fauntleroy Circus", "London", "", "EC2 5NT", "UK")),
            new Customer("CACTU", "Cactus Comidas para llevar", "(1) 135-5555", "(1) 135-4892",
                new Contact("Patricio Simpson", "Sales Agent"),
                new Address("Cerrito 333", "Buenos Aires", "", "1010", "Argentina")),
            new Customer("CENTC", "Centro comercial Moctezuma", "(5) 555-3392", "(5) 555-7293",
                new Contact("Francisco Chang", "Marketing Manager"),
                new Address("Sierras de Granada 9993", "México D.F.", "", "05022", "Mexico")),
            new Customer("CHOPS", "Chop-suey Chinese", "0452-076545", "", new Contact("Yang Wang", "Owner"),
                new Address("Hauptstr. 29", "Bern", "", "3012", "Switzerland")),
            new Customer("COMMI", "Comércio Mineiro", "(11) 555-7647", "",
                new Contact("Pedro Afonso", "Sales Associate"),
                new Address("Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil"))
        };
    }
}