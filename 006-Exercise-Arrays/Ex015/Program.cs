namespace Ex015;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var length = new int[numbers.Length];
        var prev = new int[numbers.Length];
        var bestEnd = 0;

        for (var p = 0; p < numbers.Length; p++)
        {
            length[p] = 1;
            prev[p] = -1;

            for (var left = 0; left < p; left++)
            {
                if (numbers[left] >= numbers[p] || length[left] + 1 <= length[p])
                    continue;
                length[p] = length[left] + 1;
                prev[p] = left;
            }

            if (length[p] > length[bestEnd])
                bestEnd = p;
        }

        var lis = new Stack<int>();
        for (var p = bestEnd; p != -1; p = prev[p])
            lis.Push(numbers[p]);

        Console.WriteLine(string.Join(" ", lis));
    }
}
