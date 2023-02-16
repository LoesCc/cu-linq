using Microsoft.EntityFrameworkCore;

namespace Pre.Cu.LINQ.Printing;

public static class DbSetExtensions
{
    public static List<T> Dump<T>(this DbSet<T> data, string title = null) where T: class
    {
        return data.ToList().Dump(title);
    }
}