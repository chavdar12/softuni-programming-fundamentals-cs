using System.Text.RegularExpressions;

namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var tickets = Console
            .ReadLine()
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        foreach (var ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            var left = LongestRun(ticket[..10]);
            var right = LongestRun(ticket[10..]);

            if (left.Length < 6 || right.Length < 6 || left[0] != right[0])
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
                continue;
            }

            var length = Math.Min(left.Length, right.Length);
            var jackpot = length == 10 ? " Jackpot!" : string.Empty;
            Console.WriteLine($"ticket \"{ticket}\" - {length}{left[0]}{jackpot}");
        }
    }

    private static string LongestRun(string half) =>
        Regex.Matches(half, @"([@#$^])\1*").Select(m => m.Value).MaxBy(run => run.Length) ?? string.Empty;
}
