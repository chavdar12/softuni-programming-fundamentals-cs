namespace Ex014;

internal class Program
{
    private static void Main(string[] args)
    {
        var p = new double[8];
        for (var i = 0; i < p.Length; i++)
            p[i] = double.Parse(Console.ReadLine());

        if (Length(p[0], p[1], p[2], p[3]) >= Length(p[4], p[5], p[6], p[7]))
            PrintLine(p[0], p[1], p[2], p[3]);
        else
            PrintLine(p[4], p[5], p[6], p[7]);
    }

    private static void PrintLine(double x1, double y1, double x2, double y2)
    {
        if (DistanceToCenter(x1, y1) <= DistanceToCenter(x2, y2))
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        else
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
    }

    private static double Length(double x1, double y1, double x2, double y2) =>
        Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    private static double DistanceToCenter(double x, double y) => Math.Sqrt(x * x + y * y);
}
