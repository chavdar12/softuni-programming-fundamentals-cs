namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        var area = GetRectangleArea(width, height);
        Console.WriteLine(area);
    }

    private static double GetRectangleArea(double width, double height) => width * height;
}
