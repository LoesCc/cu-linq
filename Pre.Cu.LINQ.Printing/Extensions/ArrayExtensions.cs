namespace Pre.Cu.LINQ.Printing;

public static class ArrayExtensions
{
    public static T[] Dump<T>(this T[] data, string title = null)
    {
        TablePrinter printer = TablePrinter.Instance;
        var header = $"{data.GetType()}";

        printer.Print(title,header,data.ToList());

        
        
        return data;
    }
}