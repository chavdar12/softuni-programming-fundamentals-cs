namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        PrintSign(number);
    }

    private static void PrintSign(int number)
    {
        if (number > 0)
            Console.WriteLine($"The number {number} is positive.");
        else if (number < 0)
            Console.WriteLine($"The number {number} is negative.");
        else
            Console.WriteLine($"The number {number} is zero.");
    }
}
