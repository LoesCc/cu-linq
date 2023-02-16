namespace Pre.Cu.LINQ.Printing;

public static class IListExtensions
{
    public static List<T> Dump<T>(this List<T> data, string title = null)
    {
        TablePrinter printer = TablePrinter.Instance;
        var header = $"List<{typeof(T)}> ({data.Count()} items)";
        printer.Print(title, header, data.ToList());

        return data;
    }

    internal static List<T> PrintItems<T>(this List<T> data, TablePrinter printer)
    {
        foreach (var item in data)
        {
            if (item.GetType().IsPrimitive)
            {
                printer.PrintRow(item.ToString());
            }
            else
            {
                item.Dump();
            }
        }

        return data;
    }
}