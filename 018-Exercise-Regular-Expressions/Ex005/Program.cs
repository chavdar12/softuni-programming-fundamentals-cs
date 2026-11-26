using System.Text.RegularExpressions;

namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var demons = Console
            .ReadLine()
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Order(StringComparer.Ordinal);

        foreach (var demon in demons)
        {
            var health = Regex.Matches(demon, @"[^\d+\-*/.]").Sum(m => m.Value[0]);

            var damage = Regex.Matches(demon, @"[+-]?\d+(?:\.\d+)?").Sum(m => double.Parse(m.Value));
            foreach (var symbol in demon)
                if (symbol == '*')
                    damage *= 2;
                else if (symbol == '/')
                    damage /= 2;

            Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
        }
    }
}
