namespace Pre.Cu.LINQ.Printing;

public static class IEnumerableExtesions
{
    public static List<T> Dump<T>(this IEnumerable<T> data, string title = null)
    {
        return data.ToList().Dump(title);
    }

    public static List<T> Dump<T>(this IOrderedEnumerable<T> data, string title = null)
    {
        return data.ToList().Dump(title);
    }
}