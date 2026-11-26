namespace Ex009;

internal class Person
{
    public string Name { get; set; }

    public int Age { get; set; }
}

internal class Family
{
    private readonly List<Person> members = new();

    public void AddMember(Person member) => members.Add(member);

    public Person GetOldestMember() => members.MaxBy(m => m.Age);
}

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var family = new Family();

        for (var i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split();
            family.AddMember(new Person { Name = data[0], Age = int.Parse(data[1]) });
        }

        var oldest = family.GetOldestMember();
        Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}
