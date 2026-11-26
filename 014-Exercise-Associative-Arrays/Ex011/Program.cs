namespace Ex011;

internal class Program
{
    private static void Main(string[] args)
    {
        var contests = new Dictionary<string, string>();

        string input;
        while ((input = Console.ReadLine()) != "end of contests")
        {
            var data = input.Split(':');
            contests[data[0]] = data[1];
        }

        var users = new SortedDictionary<string, Dictionary<string, int>>(StringComparer.Ordinal);

        while ((input = Console.ReadLine()) != "end of submissions")
        {
            var data = input.Split("=>");
            var contest = data[0];
            var password = data[1];
            var user = data[2];
            var points = int.Parse(data[3]);

            if (!contests.TryGetValue(contest, out var expected) || expected != password)
                continue;
            if (!users.ContainsKey(user))
                users[user] = new Dictionary<string, int>();

            users[user][contest] = Math.Max(users[user].GetValueOrDefault(contest), points);
        }

        var best = users.MaxBy(u => u.Value.Values.Sum());
        Console.WriteLine($"Best candidate is {best.Key} with total {best.Value.Values.Sum()} points.");
        Console.WriteLine("Ranking:");

        foreach (var (user, userContests) in users)
        {
            Console.WriteLine(user);
            foreach (var (contest, points) in userContests.OrderByDescending(c => c.Value))
                Console.WriteLine($"#  {contest} -> {points}");
        }
    }
}
