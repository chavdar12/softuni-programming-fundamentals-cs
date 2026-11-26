using System.Text.RegularExpressions;

namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        const string pattern =
            @"@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>[AD])![^@\-!:>]*->(?<soldiers>\d+)";

        var attacked = new List<string>();
        var destroyed = new List<string>();

        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var message = Console.ReadLine();
            var key = message.Count(c => "star".Contains(char.ToLower(c)));
            var decrypted = new string(message.Select(c => (char)(c - key)).ToArray());

            var match = Regex.Match(decrypted, pattern);
            if (!match.Success)
                continue;

            var planet = match.Groups["planet"].Value;
            if (match.Groups["type"].Value == "A")
                attacked.Add(planet);
            else
                destroyed.Add(planet);
        }

        Console.WriteLine($"Attacked planets: {attacked.Count}");
        foreach (var planet in attacked.Order(StringComparer.Ordinal))
            Console.WriteLine($"-> {planet}");

        Console.WriteLine($"Destroyed planets: {destroyed.Count}");
        foreach (var planet in destroyed.Order(StringComparer.Ordinal))
            Console.WriteLine($"-> {planet}");
    }
}
