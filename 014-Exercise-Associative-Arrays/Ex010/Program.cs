namespace Ex010;

internal class Program
{
    private static void Main(string[] args)
    {
        var results = new Dictionary<string, int>();
        var submissions = new Dictionary<string, int>();

        string input;
        while ((input = Console.ReadLine()) != "exam finished")
        {
            var data = input.Split('-');
            var user = data[0];

            if (data[1] == "banned")
            {
                results.Remove(user);
                continue;
            }

            var language = data[1];
            var points = int.Parse(data[2]);

            results[user] = Math.Max(results.GetValueOrDefault(user), points);
            submissions[language] = submissions.GetValueOrDefault(language) + 1;
        }

        Console.WriteLine("Results:");
        foreach (var (user, points) in results.OrderByDescending(r => r.Value).ThenBy(r => r.Key))
            Console.WriteLine($"{user} | {points}");

        Console.WriteLine("Submissions:");
        foreach (var (language, count) in submissions.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            Console.WriteLine($"{language} - {count}");
    }
}
