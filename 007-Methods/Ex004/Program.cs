namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        PrintTriangle(n);
    }

    private static void PrintTriangle(int n)
    {
        for (var i = 1; i <= n; i++)
            PrintLine(1, i);
        for (var i = n - 1; i >= 1; i--)
            PrintLine(1, i);
    }

    private static void PrintLine(int start, int end)
    {
        for (var i = start; i <= end; i++)
            Console.Write($"{i} ");

        Console.WriteLine();
    }
}
