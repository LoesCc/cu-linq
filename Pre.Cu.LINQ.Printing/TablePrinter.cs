namespace Pre.Cu.LINQ.Printing;

public class TablePrinter
{
    private int _tableWidth;

    public static TablePrinter Instance
    {
        get { return NestedTablePrinter.instance; }
    }

    public int Width
    {
        set { _tableWidth = value; }
    }

    public int Indent { get; set; }
    public bool IsPrinting { get; set; }

    private TablePrinter(int tableWidth = 75)
    {
        _tableWidth = tableWidth;
    }

    public void PrintLine(char lineCharacter = '-')
    {
        var dashedLine = new string(lineCharacter, _tableWidth);

        Console.WriteLine(dashedLine.PadLeft(dashedLine.Length - 1 + Indent));
    }

    public void PrintRow(params string[] columns)
    {
        int width = (_tableWidth - columns.Length) / columns.Length;
        string row = "|".PadLeft(Indent);

        foreach (string column in columns)
        {
            row += AlignCentre(column, width) + "|";
        }

        Console.WriteLine(row);
    }

    private string AlignCentre(string text, int width)
    {
        text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

        if (string.IsNullOrEmpty(text))
        {
            return new string(' ', width);
        }
        else
        {
            return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
    }

    private class NestedTablePrinter
    {
        static NestedTablePrinter()
        {
        }

        internal static readonly TablePrinter instance = new TablePrinter();
    }

    public void ResetMargin()
    {
        Indent = 0;
    }

    public void PrintTitle(string title, ConsoleColor titleColor = ConsoleColor.Blue)
    {
        var tmpForegroundColor = Console.ForegroundColor;
        Console.ForegroundColor = titleColor;
        Console.WriteLine($">> \x1b[1m{title}\x1b[0m");
        Console.ForegroundColor = tmpForegroundColor;
    }

    public void Print<T>(string title, string header, List<T> data)
    {
        if (!string.IsNullOrWhiteSpace(title))
        {
            PrintTitle(title);
        }

        IsPrinting = true;
        PrintLine();
        PrintRow(header);
        PrintLine();

        data.ToList().PrintItems(this);
        
        IsPrinting = false;
    }
}