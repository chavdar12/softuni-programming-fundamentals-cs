namespace Ex014;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var k = numbers.Length / 4;

        var upper = numbers.Take(k).Reverse().Concat(numbers.Skip(3 * k).Reverse()).ToArray();
        var lower = numbers.Skip(k).Take(2 * k).ToArray();

        Console.WriteLine(string.Join(" ", upper.Select((n, i) => n + lower[i])));
    }
}
