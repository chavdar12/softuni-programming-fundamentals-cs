namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var largest = Console
            .ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderDescending()
            .Take(3);

        Console.WriteLine(string.Join(" ", largest));
    }
}
