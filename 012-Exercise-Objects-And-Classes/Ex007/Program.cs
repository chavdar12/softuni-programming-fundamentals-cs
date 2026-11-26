namespace Ex007;

internal class Person
{
    public string Name { get; set; }

    public string Id { get; set; }

    public int Age { get; set; }

    public override string ToString() => $"{Name} with ID: {Id} is {Age} years old.";
}

internal class Program
{
    private static void Main(string[] args)
    {
        var people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var data = input.Split();
            var person = people.FirstOrDefault(p => p.Id == data[1]);

            if (person is null)
            {
                person = new Person { Id = data[1] };
                people.Add(person);
            }

            person.Name = data[0];
            person.Age = int.Parse(data[2]);
        }

        foreach (var person in people.OrderBy(p => p.Age))
            Console.WriteLine(person);
    }
}
