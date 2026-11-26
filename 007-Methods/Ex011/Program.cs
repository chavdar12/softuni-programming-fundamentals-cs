namespace Ex011;

internal class Program
{
    private static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var @operator = char.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        Console.WriteLine(Calculate(a, @operator, b));
    }

    private static double Calculate(int a, char @operator, int b)
    {
        return @operator switch
        {
            '/' => (double)a / b,
            '*' => a * b,
            '+' => a + b,
            '-' => a - b,
            _ => 0,
        };
    }
}
