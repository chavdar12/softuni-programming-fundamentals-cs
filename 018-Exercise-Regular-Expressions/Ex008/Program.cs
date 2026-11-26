using System.Text;
using System.Text.RegularExpressions;

namespace Ex008;

internal class Program
{
    private static void Main(string[] args)
    {
        var message = new StringBuilder();

        foreach (Match match in Regex.Matches(Console.ReadLine(), @"(?<text>\D+)(?<count>\d+)"))
        {
            var text = match.Groups["text"].Value.ToUpper();
            var count = int.Parse(match.Groups["count"].Value);

            for (var i = 0; i < count; i++)
                message.Append(text);
        }

        var result = message.ToString();
        Console.WriteLine($"Unique symbols used: {result.Distinct().Count()}");
        Console.WriteLine(result);
    }
}
