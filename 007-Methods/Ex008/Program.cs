namespace Ex008;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = double.Parse(Console.ReadLine());
        var power = int.Parse(Console.ReadLine());

        Console.WriteLine(RaiseToPower(number, power));
    }

    private static double RaiseToPower(double number, int power) => Math.Pow(number, power);
}
