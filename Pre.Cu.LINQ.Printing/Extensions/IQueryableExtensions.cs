namespace Pre.Cu.LINQ.Printing;

public static class IQueryableExtensions
{
    public static List<T> Dump<T>(this IQueryable<T> data, string title = null)
    {
        return data.ToList().Dump(title);
    }

    public static List<T> Dump<T>(this IOrderedQueryable<T> data, string title = null)
    {
        return data.ToList().Dump(title);
    }
}