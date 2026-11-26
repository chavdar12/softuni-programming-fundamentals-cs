namespace Ex012;

internal class Program
{
    private static void Main(string[] args)
    {
        var type = Console.ReadLine();
        var value = Console.ReadLine();

        switch (type)
        {
            case "int":
                Print(int.Parse(value));
                break;
            case "real":
                Print(double.Parse(value));
                break;
            case "string":
                Print(value);
                break;
        }
    }

    private static void Print(int value) => Console.WriteLine(value * 2);

    private static void Print(double value) => Console.WriteLine($"{value * 1.5:f2}");

    private static void Print(string value) => Console.WriteLine($"${value}$");
}
