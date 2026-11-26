namespace Ex011;

internal class Engine
{
    public int Speed { get; set; }

    public int Power { get; set; }
}

internal class Cargo
{
    public int Weight { get; set; }

    public string Type { get; set; }
}

internal class Car
{
    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
    {
        Model = model;
        Engine = new Engine { Speed = engineSpeed, Power = enginePower };
        Cargo = new Cargo { Weight = cargoWeight, Type = cargoType };
    }

    public string Model { get; }

    public Engine Engine { get; }

    public Cargo Cargo { get; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (var i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split();
            cars.Add(new Car(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), data[4]));
        }

        var command = Console.ReadLine();
        var filtered =
            command == "fragile"
                ? cars.Where(c => c.Cargo.Type == "fragile" && c.Cargo.Weight < 1000)
                : cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250);

        foreach (var car in filtered)
            Console.WriteLine(car.Model);
    }
}
