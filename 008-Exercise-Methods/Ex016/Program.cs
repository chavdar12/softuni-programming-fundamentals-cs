namespace Ex016;

internal class Program
{
    private static void Main(string[] args)
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        var num3 = int.Parse(Console.ReadLine());

        Console.WriteLine(GetProductSign(num1, num2, num3));
    }

    private static string GetProductSign(int num1, int num2, int num3)
    {
        if (num1 == 0 || num2 == 0 || num3 == 0)
            return "zero";

        var negatives = new[] { num1, num2, num3 }.Count(n => n < 0);
        return negatives % 2 == 0 ? "positive" : "negative";
    }
}
