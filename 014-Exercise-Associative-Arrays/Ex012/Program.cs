namespace Ex012;

internal class Program
{
    private static void Main(string[] args)
    {
        var contests = new Dictionary<string, Dictionary<string, int>>();

        string input;
        while ((input = Console.ReadLine()) != "no more time")
        {
            var data = input.Split(" -> ");
            var user = data[0];
            var contest = data[1];
            var points = int.Parse(data[2]);

            if (!contests.ContainsKey(contest))
                contests[contest] = new Dictionary<string, int>();

            contests[contest][user] = Math.Max(contests[contest].GetValueOrDefault(user), points);
        }

        foreach (var (contest, participants) in contests)
        {
            Console.WriteLine($"{contest}: {participants.Count} participants");
            PrintStandings(participants, "<::>");
        }

        var totals = contests
            .Values.SelectMany(c => c)
            .GroupBy(p => p.Key)
            .ToDictionary(g => g.Key, g => g.Sum(p => p.Value));

        Console.WriteLine("Individual standings:");
        PrintStandings(totals, "->");
    }

    private static void PrintStandings(Dictionary<string, int> standings, string separator)
    {
        var position = 1;
        foreach (var (user, points) in standings.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            Console.WriteLine($"{position++}. {user} {separator} {points}");
    }
}
