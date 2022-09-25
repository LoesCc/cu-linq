namespace Pre.Cu.LINQ.Printing;

public static class IListExtensions
{
    public static List<T> Dump<T>(this List<T> data, string? title = null)
    {
        TablePrinter printer = TablePrinter.Instance;
        var header = $"List<{typeof(T)}> ({data.Count()} items)";
        data = data.ToList();
        
        if (!string.IsNullOrWhiteSpace(title))
        {
            printer.PrintTitle(title);
        }

        printer.IsPrinting = true;
        printer.PrintLine();
        printer.PrintRow(header);
        printer.PrintLine();

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

        printer.PrintLine();
        printer.IsPrinting = false;
        
        return data;
    }
}