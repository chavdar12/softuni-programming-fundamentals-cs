namespace Ex013;

internal class Program
{
    private static void Main(string[] args)
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        PrintClosestPoint(x1, y1, x2, y2);
    }

    private static void PrintClosestPoint(double x1, double y1, double x2, double y2)
    {
        if (DistanceToCenter(x1, y1) <= DistanceToCenter(x2, y2))
            Console.WriteLine($"({x1}, {y1})");
        else
            Console.WriteLine($"({x2}, {y2})");
    }

    private static double DistanceToCenter(double x, double y) => Math.Sqrt(x * x + y * y);
}
