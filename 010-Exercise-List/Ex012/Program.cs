namespace Ex012;

internal class Program
{
    private static void Main(string[] args)
    {
        var times = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var middle = times.Length / 2;
        var left = GetTotalTime(times.Take(middle));
        var right = GetTotalTime(times.Skip(middle + 1).Reverse());

        if (left <= right)
            Console.WriteLine($"The winner is left with total time: {left}");
        else
            Console.WriteLine($"The winner is right with total time: {right}");
    }

    private static double GetTotalTime(IEnumerable<int> steps)
    {
        double total = 0;
        foreach (var step in steps)
            total = step == 0 ? total * 0.8 : total + step;

        return Math.Round(total, 2);
    }
}
