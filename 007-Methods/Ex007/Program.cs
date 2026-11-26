namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine();
        var count = int.Parse(Console.ReadLine());

        Console.WriteLine(RepeatString(text, count));
    }

    private static string RepeatString(string text, int count) => string.Concat(Enumerable.Repeat(text, count));
}
