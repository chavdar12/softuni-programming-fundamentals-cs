namespace Ex014;

internal class Program
{
    private static void Main(string[] args)
    {
        // Dictionary keeps insertion order when a value is only updated, which the stable sort below relies on.
        var dwarfs = new Dictionary<(string Name, string Color), int>();

        string input;
        while ((input = Console.ReadLine()) != "Once upon a time")
        {
            var data = input.Split(" <:> ");
            var key = (data[0], data[1]);
            var physics = int.Parse(data[2]);

            dwarfs[key] = Math.Max(dwarfs.GetValueOrDefault(key), physics);
        }

        var colorCounts = dwarfs.Keys.GroupBy(d => d.Color).ToDictionary(g => g.Key, g => g.Count());

        foreach (
            var ((name, color), physics) in dwarfs
                .OrderByDescending(d => d.Value)
                .ThenByDescending(d => colorCounts[d.Key.Color])
        )
            Console.WriteLine($"({color}) {name} <-> {physics}");
    }
}
