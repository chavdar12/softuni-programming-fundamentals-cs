using System.Text.RegularExpressions;

namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        const string pattern =
            @"(?<=\s|^)[A-Za-z0-9]+(?:[._-][A-Za-z0-9]+)*@[A-Za-z]+(?:-[A-Za-z]+)*(?:\.[A-Za-z]+(?:-[A-Za-z]+)*)+";

        foreach (Match email in Regex.Matches(Console.ReadLine(), pattern))
            Console.WriteLine(email.Value);
    }
}
