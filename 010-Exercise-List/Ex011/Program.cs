namespace Ex011;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var text = Console.ReadLine().ToList();
        var message = string.Empty;

        foreach (var number in numbers)
        {
            var index = number.Sum(c => c - '0') % text.Count;
            message += text[index];
            text.RemoveAt(index);
        }

        Console.WriteLine(message);
    }
}
