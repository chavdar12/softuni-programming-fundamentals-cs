namespace Ex013;

internal class Program
{
    private static void Main(string[] args)
    {
        var players = new Dictionary<string, Dictionary<string, int>>();

        string input;
        while ((input = Console.ReadLine()) != "Season end")
        {
            if (input.Contains(" -> "))
            {
                var data = input.Split(" -> ");
                var player = data[0];
                var position = data[1];
                var skill = int.Parse(data[2]);

                if (!players.ContainsKey(player))
                    players[player] = new Dictionary<string, int>();

                players[player][position] = Math.Max(players[player].GetValueOrDefault(position), skill);
            }
            else
            {
                var data = input.Split(" vs ");
                if (!players.TryGetValue(data[0], out var first) || !players.TryGetValue(data[1], out var second))
                    continue;

                if (!first.Keys.Intersect(second.Keys).Any())
                    continue;

                var firstTotal = first.Values.Sum();
                var secondTotal = second.Values.Sum();

                if (firstTotal > secondTotal)
                    players.Remove(data[1]);
                else if (secondTotal > firstTotal)
                    players.Remove(data[0]);
            }
        }

        foreach (var (player, positions) in players.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
        {
            Console.WriteLine($"{player}: {positions.Values.Sum()} skill");
            foreach (var (position, skill) in positions.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                Console.WriteLine($"- {position} <::> {skill}");
        }
    }
}
