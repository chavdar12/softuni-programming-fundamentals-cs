namespace Ex015;

internal class Dragon
{
    public int Damage { get; set; }

    public int Health { get; set; }

    public int Armor { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var types = new Dictionary<string, SortedDictionary<string, Dragon>>();

        for (var i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split();
            var type = data[0];
            var name = data[1];

            if (!types.ContainsKey(type))
                types[type] = new SortedDictionary<string, Dragon>(StringComparer.Ordinal);

            types[type][name] = new Dragon
            {
                Damage = ParseStat(data[2], 45),
                Health = ParseStat(data[3], 250),
                Armor = ParseStat(data[4], 10),
            };
        }

        foreach (var (type, dragons) in types)
        {
            var averageDamage = dragons.Values.Average(d => d.Damage);
            var averageHealth = dragons.Values.Average(d => d.Health);
            var averageArmor = dragons.Values.Average(d => d.Armor);
            Console.WriteLine($"{type}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

            foreach (var (name, dragon) in dragons)
                Console.WriteLine(
                    $"-{name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}"
                );
        }
    }

    private static int ParseStat(string value, int defaultValue) => value == "null" ? defaultValue : int.Parse(value);
}
