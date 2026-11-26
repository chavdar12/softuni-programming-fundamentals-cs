namespace Ex012;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        long[] row = { 1 };

        for (var i = 0; i < n; i++)
        {
            Console.WriteLine(string.Join(" ", row));

            var next = new long[row.Length + 1];
            next[0] = 1;
            next[^1] = 1;
            for (var j = 1; j < row.Length; j++)
                next[j] = row[j - 1] + row[j];

            row = next;
        }
    }
}
