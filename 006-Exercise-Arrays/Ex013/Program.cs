namespace Ex013;

internal class Program
{
    private static readonly Dictionary<int, long> Memo = new();

    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine(GetFibonacci(n));
    }

    private static long GetFibonacci(int n)
    {
        if (n <= 2)
            return 1;
        if (Memo.TryGetValue(n, out var cached))
            return cached;

        return Memo[n] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
    }
}
