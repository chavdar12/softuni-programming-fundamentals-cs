namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var product = Console.ReadLine();
        var quantity = int.Parse(Console.ReadLine());
        PrintTotalPrice(product, quantity);
    }

    private static void PrintTotalPrice(string product, int quantity)
    {
        var price = product switch
        {
            "coffee" => 1.50,
            "water" => 1.00,
            "coke" => 1.40,
            "snacks" => 2.00,
            _ => 0,
        };

        Console.WriteLine($"{price * quantity:f2}");
    }
}
