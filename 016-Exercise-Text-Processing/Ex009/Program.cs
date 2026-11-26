namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            var line = Console.ReadLine();

            var name = Between(line, '@', '|');
            var age = Between(line, '#', '*');

            Console.WriteLine($"{name} is {age} years old.");
        }
    }

    private static string Between(string text, char start, char end)
    {
        var from = text.IndexOf(start) + 1;
        return text.Substring(from, text.IndexOf(end, from) - from);
    }
}
