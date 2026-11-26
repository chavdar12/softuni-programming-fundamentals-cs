namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var sides = new Dictionary<string, List<string>>();

        string input;
        while ((input = Console.ReadLine()) != "Lumpawaroo")
        {
            if (input.Contains(" | "))
            {
                var data = input.Split(" | ");
                var side = data[0];
                var user = data[1];

                if (sides.Values.Any(users => users.Contains(user)))
                    continue;
                if (!sides.ContainsKey(side))
                    sides[side] = new List<string>();

                sides[side].Add(user);
            }
            else
            {
                var data = input.Split(" -> ");
                var user = data[0];
                var side = data[1];

                foreach (var users in sides.Values)
                    users.Remove(user);
                if (!sides.ContainsKey(side))
                    sides[side] = new List<string>();

                sides[side].Add(user);
                Console.WriteLine($"{user} joins the {side} side!");
            }
        }

        foreach (
            var (side, users) in sides
                .Where(s => s.Value.Count > 0)
                .OrderByDescending(s => s.Value.Count)
                .ThenBy(s => s.Key)
        )
        {
            Console.WriteLine($"Side: {side}, Members: {users.Count}");
            foreach (var user in users.Order())
                Console.WriteLine($"! {user}");
        }
    }
}
