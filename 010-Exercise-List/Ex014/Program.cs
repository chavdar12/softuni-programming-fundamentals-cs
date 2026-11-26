namespace Ex014;

internal class Program
{
    private static void Main(string[] args)
    {
        var first = ReadNumbers();
        var second = ReadNumbers();
        second.Reverse();

        var mixed = new List<int>();
        var pairs = Math.Min(first.Count, second.Count);
        for (var i = 0; i < pairs; i++)
        {
            mixed.Add(first[i]);
            mixed.Add(second[i]);
        }

        var bounds = first.Count > second.Count ? first.Skip(pairs).ToList() : second.Skip(pairs).ToList();
        var lower = bounds.Min();
        var upper = bounds.Max();

        var result = mixed.Where(n => n > lower && n < upper).Order();
        Console.WriteLine(string.Join(" ", result));
    }

    private static List<int> ReadNumbers() =>
        Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
}
