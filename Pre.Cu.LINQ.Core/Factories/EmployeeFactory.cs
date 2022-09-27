using Pre.Cu.LINQ.Core.Domain;

namespace Pre.Cu.LINQ.Core.Factories;

public class EmployeeFactory : IEmployeeFactory
{
    public EmployeeFactory()
    {
    }

    public IEnumerable<Employee> CreateDefaults()
    {
        return new List<Employee>()
        {
            new Employee(1, "Davolio", "Nancy", "Sales Representative", "Ms.", DateTime.Parse("Dec  8 1948 12:00AM"),
                DateTime.Parse("May  1 1992 12:00AM"),
                new Address("507 - 20th Ave. E. Apt. 2A", "Seattle", "WA", "98122", "USA"), "(206) 555-9857", "5467",
                "2",
                "Education includes a BA in psychology from Colorado State University in 1970.She also completed " +
                "'The Art of the Cold Call' Nancy is a member of Toastmasters International."),
            new Employee(2, "Fuller", "Andrew", "Vice President, Sales", "Dr.", DateTime.Parse("Feb 19 1952 12:00AM"),
                DateTime.Parse("Aug 14 1992 12:00AM"),
                new Address("908 W. Capital Way", "Tacoma", "WA", "98401", "USA"), "(206) 555-9482", "3457", "",
                "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981. " +
                " He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager " +
                "in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber " +
                "of Commerce, and the Pacific Rim Importers Association."),
            new Employee(3, "Leverling", "Janet", "Sales Representative", "Ms.", DateTime.Parse("Aug 30 1963 12:00AM"),
                DateTime.Parse("Apr  1 1992 12:00AM"),
                new Address("722 Moss Bay Blvd.", "Kirkland", "WA", "98033", "USA"), "(206) 555-3412", "3355", "2",
                "Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992."),
            new Employee(4, "Peacock", "Margaret", "Sales Representative", "Mrs.",
                DateTime.Parse("Sep 19 1937 12:00AM"), DateTime.Parse("May  3 1993 12:00AM"),
                new Address("4110 Old Redmond Rd.", "Redmond", "WA", "98052", "USA"), "(206) 555-8122", "5176", "2",
                "Margaret holds a BA in English literature from Concordia College (1958) and an MA from the American Institute of Culinary Arts (1966).  She was assigned to the London office temporarily from July through November 1992."),
            new Employee(5, "Buchanan", "Steven", "Sales Manager", "Mr.", DateTime.Parse("Mar  4 1955 12:00AM"),
                DateTime.Parse("Oct 17 1993 12:00AM"), new Address("14 Garrett Hill", "London", "", "SW1 8JR", "UK"),
                "(71) 555-4848", "3453", "2",
                "Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.  Mr. Buchanan has completed the courses \"Successful Telemarketing\" and \"International Sales Management.\"  He is fluent in French."),
            new Employee(6, "Suyama", "Michael", "Sales Representative", "Mr.", DateTime.Parse("Jul  2 1963 12:00AM"),
                DateTime.Parse("Oct 17 1993 12:00AM"),
                new Address("Coventry House Miner Rd.", "London", "", "EC2 7JR", "UK"), "(71) 555-7773", "428", "5",
                "Michael is a graduate of Sussex University (MA, economics, 1983) and the University of California at Los Angeles (MBA, marketing, 1986).  He has also taken the courses \"Multi-Cultural Selling\" and \"Time Management for the Sales Professional.\"  He is fluent in Japanese and can read and write French, Portuguese, and Spanish."),
            new Employee(7, "King", "Robert", "Sales Representative", "Mr.", DateTime.Parse("May 29 1960 12:00AM"),
                DateTime.Parse("Jan  2 1994 12:00AM"),
                new Address("Edgeham Hollow Winchester Way", "London", "", "RG1 9SP", "UK"), "(71) 555-5598", "465",
                "5",
                "Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the University of Michigan in 1992, the year he joined the company.  After completing a course entitled \"Selling in Europe,\" he was transferred to the London office in March 1993."),
            new Employee(8, "Callahan", "Laura", "Inside Sales Coordinator", "Ms.",
                DateTime.Parse("Jan  9 1958 12:00AM"), DateTime.Parse("Mar  5 1994 12:00AM"),
                new Address("4726 - 11th Ave. N.E.", "Seattle", "WA", "98105", "USA"), "(206) 555-1189", "2344", "2",
                "Laura received a BA in psychology from the University of Washington.  She has also completed a course in business French.  She reads and writes French."),
            new Employee(9, "Dodsworth", "Anne", "Sales Representative", "Ms.", DateTime.Parse("Jan 27 1966 12:00AM"),
                DateTime.Parse("Nov 15 1994 12:00AM"), new Address("7 Houndstooth Rd.", "London", "", "WG2 7LT", "UK"),
                "(71) 555-4444", "452", "5",
                "Anne has a BA degree in English from St. Lawrence College.  She is fluent in French and German."),
        };
    }
}