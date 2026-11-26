using System.Text.RegularExpressions;

namespace Ex010;

internal class Program
{
    private static void Main(string[] args)
    {
        const string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behaviour>[GN])!";

        var key = int.Parse(Console.ReadLine());

        string message;
        while ((message = Console.ReadLine()) != "end")
        {
            var decrypted = new string(message.Select(c => (char)(c - key)).ToArray());
            var match = Regex.Match(decrypted, pattern);

            if (match.Success && match.Groups["behaviour"].Value == "G")
                Console.WriteLine(match.Groups["name"].Value);
        }
    }
}
