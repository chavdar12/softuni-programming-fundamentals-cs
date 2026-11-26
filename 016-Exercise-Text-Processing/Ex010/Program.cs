namespace Ex010;

internal class Program
{
    private static void Main(string[] args)
    {
        var first = char.Parse(Console.ReadLine());
        var second = char.Parse(Console.ReadLine());
        var text = Console.ReadLine();

        var lower = (char)Math.Min(first, second);
        var upper = (char)Math.Max(first, second);

        Console.WriteLine(text.Where(c => c > lower && c < upper).Sum(c => c));
    }
}
