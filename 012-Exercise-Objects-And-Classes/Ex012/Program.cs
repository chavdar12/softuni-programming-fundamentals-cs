namespace Ex012;

internal class Product
{
    public string Name { get; set; }

    public decimal Cost { get; set; }
}

internal class Person
{
    public string Name { get; set; }

    public decimal Money { get; set; }

    public List<Product> Bag { get; } = new();

    public override string ToString() =>
        Bag.Count == 0 ? $"{Name} - Nothing bought" : $"{Name} - {string.Join(", ", Bag.Select(p => p.Name))}";
}

internal class Program
{
    private static void Main(string[] args)
    {
        var people = ParsePairs(Console.ReadLine()).Select(p => new Person { Name = p.Name, Money = p.Value }).ToList();
        var products = ParsePairs(Console.ReadLine())
            .Select(p => new Product { Name = p.Name, Cost = p.Value })
            .ToList();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            var data = command.Split();
            var person = people.First(p => p.Name == data[0]);
            var product = products.First(p => p.Name == data[1]);

            if (person.Money < product.Cost)
            {
                Console.WriteLine($"{person.Name} can't afford {product.Name}");
                continue;
            }

            person.Money -= product.Cost;
            person.Bag.Add(product);
            Console.WriteLine($"{person.Name} bought {product.Name}");
        }

        foreach (var person in people)
            Console.WriteLine(person);
    }

    private static IEnumerable<(string Name, decimal Value)> ParsePairs(string line) =>
        line.Split(';', StringSplitOptions.RemoveEmptyEntries)
            .Select(pair => pair.Split('='))
            .Select(pair => (pair[0], decimal.Parse(pair[1])));
}
