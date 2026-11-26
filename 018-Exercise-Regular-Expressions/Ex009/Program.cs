using System.Text.RegularExpressions;

namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var parts = Console.ReadLine().Split('|');

        var capitals = Regex.Match(parts[0], @"([#$%*&])(?<letters>[A-Z]+)\1").Groups["letters"].Value;

        var lengths = new Dictionary<char, int>();
        foreach (Match match in Regex.Matches(parts[1], @"(?<code>\d{2}):(?<length>\d{2})"))
        {
            var letter = (char)int.Parse(match.Groups["code"].Value);
            if (capitals.Contains(letter))
                lengths.TryAdd(letter, int.Parse(match.Groups["length"].Value) + 1);
        }

        var words = parts[2].Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var letter in capitals)
        {
            if (!lengths.TryGetValue(letter, out var length))
                continue;

            foreach (var word in words.Where(w => w[0] == letter && w.Length == length))
                Console.WriteLine(word);
        }
    }
}
