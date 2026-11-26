namespace Ex006;

internal class Vehicle
{
    public string Type { get; set; }

    public string Model { get; set; }

    public string Color { get; set; }

    public int HorsePower { get; set; }

    public override string ToString() => $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";
}

internal class Program
{
    private static void Main(string[] args)
    {
        var vehicles = new List<Vehicle>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var data = input.Split();
            vehicles.Add(
                new Vehicle
                {
                    Type = data[0] == "car" ? "Car" : "Truck",
                    Model = data[1],
                    Color = data[2],
                    HorsePower = int.Parse(data[3]),
                }
            );
        }

        while ((input = Console.ReadLine()) != "Close the Catalogue")
        {
            var model = input;
            foreach (var vehicle in vehicles.Where(v => v.Model == model))
                Console.WriteLine(vehicle);
        }

        Console.WriteLine($"Cars have average horsepower of: {AverageHorsePower(vehicles, "Car"):f2}.");
        Console.WriteLine($"Trucks have average horsepower of: {AverageHorsePower(vehicles, "Truck"):f2}.");
    }

    private static double AverageHorsePower(List<Vehicle> vehicles, string type)
    {
        var ofType = vehicles.Where(v => v.Type == type).ToList();
        return ofType.Count == 0 ? 0 : ofType.Average(v => v.HorsePower);
    }
}
