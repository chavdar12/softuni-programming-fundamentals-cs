namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var command = Console.ReadLine();
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        switch (command)
        {
            case "add":
                Add(a, b);
                break;
            case "multiply":
                Multiply(a, b);
                break;
            case "subtract":
                Subtract(a, b);
                break;
            case "divide":
                Divide(a, b);
                break;
        }
    }

    private static void Add(int a, int b) => Console.WriteLine(a + b);

    private static void Multiply(int a, int b) => Console.WriteLine(a * b);

    private static void Subtract(int a, int b) => Console.WriteLine(a - b);

    private static void Divide(int a, int b) => Console.WriteLine(a / b);
}
