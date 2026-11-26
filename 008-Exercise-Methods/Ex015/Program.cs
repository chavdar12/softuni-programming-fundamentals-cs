namespace Ex015;

internal class Program
{
    private static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());
        Console.WriteLine(string.Join(" ", GetTribonacci(num)));
    }

    private static long[] GetTribonacci(int count)
    {
        var sequence = new long[count];

        for (var i = 0; i < count; i++)
            sequence[i] = i switch
            {
                0 or 1 => 1,
                2 => 2,
                _ => sequence[i - 1] + sequence[i - 2] + sequence[i - 3],
            };

        return sequence;
    }
}
