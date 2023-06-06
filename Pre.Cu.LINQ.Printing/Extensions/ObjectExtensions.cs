namespace Pre.Cu.LINQ.Printing;

public static class ObjectExtensions
{
    public static T Dump<T>(this T data, string title = null)
    {
        TablePrinter printer = TablePrinter.Instance;
        if (data != null && !data.GetType().IsPrimitive && printer.IsPrinting)
        {
            printer.Indent = 5;
        }

        var header = $"{data?.GetType()}";

        if (!string.IsNullOrWhiteSpace(title))
        {
            printer.PrintTitle(title);
        }

        printer.PrintLine();
        printer.PrintRow(header);
        printer.PrintLine();

        if (data == null)
        {
            printer.PrintRow("null");
        }
        else if (data.GetType().IsPrimitive || data is string || data is decimal)
        {
            printer.PrintRow(data.ToString() ?? string.Empty);
        }
        else
        {
            DumpObject(data);
        }

        printer.PrintLine();
        if (data != null && !data.GetType().IsPrimitive)
        {
            printer.ResetMargin();
        }

        return data;
    }

    private static void DumpObject<T>(T data)
    {
        var printer = TablePrinter.Instance;
        var properties = data.GetType().GetProperties();
        printer.PrintRow("Property", "Value");
        printer.PrintLine('=');

        foreach (var property in properties)
        {
            printer.PrintRow(property.Name, property.GetValue(data)?.ToString() ?? string.Empty);
        }
    }
}