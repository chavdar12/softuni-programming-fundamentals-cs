namespace Ex005;

internal class Team
{
    public string Name { get; set; }

    public string Creator { get; set; }

    public List<string> Members { get; } = new();
}

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var teams = new List<Team>();

        for (var i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split('-', 2);
            var user = data[0];
            var teamName = data[1];

            if (teams.Any(t => t.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }

            if (teams.Any(t => t.Creator == user))
            {
                Console.WriteLine($"{user} cannot create another team!");
                continue;
            }

            teams.Add(new Team { Name = teamName, Creator = user });
            Console.WriteLine($"Team {teamName} has been created by {user}!");
        }

        string command;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            var data = command.Split("->", 2);
            var user = data[0];
            var teamName = data[1];

            var team = teams.FirstOrDefault(t => t.Name == teamName);
            if (team is null)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }

            if (teams.Any(t => t.Creator == user || t.Members.Contains(user)))
            {
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
                continue;
            }

            team.Members.Add(user);
        }

        foreach (
            var team in teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name, StringComparer.Ordinal)
        )
        {
            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");
            foreach (var member in team.Members.Order(StringComparer.Ordinal))
                Console.WriteLine($"-- {member}");
        }

        Console.WriteLine("Teams to disband:");
        foreach (var team in teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name, StringComparer.Ordinal))
            Console.WriteLine(team.Name);
    }
}
