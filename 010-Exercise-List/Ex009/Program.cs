namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var distances = Console
            .ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToList();

        long removedSum = 0;

        while (distances.Count > 0)
        {
            var index = int.Parse(Console.ReadLine());
            long removed;

            if (index < 0)
            {
                removed = distances[0];
                distances[0] = distances[^1];
            }
            else if (index >= distances.Count)
            {
                removed = distances[^1];
                distances[^1] = distances[0];
            }
            else
            {
                removed = distances[index];
                distances.RemoveAt(index);
            }

            removedSum += removed;

            for (var i = 0; i < distances.Count; i++)
                distances[i] += distances[i] <= removed ? removed : -removed;
        }

        Console.WriteLine(removedSum);
    }
}
