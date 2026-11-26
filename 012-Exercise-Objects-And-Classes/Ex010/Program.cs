namespace Ex010;

internal class Car
{
    public string Model { get; set; }

    public double FuelAmount { get; set; }

    public double FuelConsumptionPerKm { get; set; }

    public int TraveledDistance { get; set; }

    public bool Drive(int km)
    {
        var neededFuel = km * FuelConsumptionPerKm;
        if (neededFuel > FuelAmount)
            return false;

        FuelAmount -= neededFuel;
        TraveledDistance += km;
        return true;
    }

    public override string ToString() => $"{Model} {FuelAmount:f2} {TraveledDistance}";
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
            cars.Add(
                new Car
                {
                    Model = data[0],
                    FuelAmount = double.Parse(data[1]),
                    FuelConsumptionPerKm = double.Parse(data[2]),
                }
            );
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var data = command.Split();
            var car = cars.First(c => c.Model == data[1]);

            if (!car.Drive(int.Parse(data[2])))
                Console.WriteLine("Insufficient fuel for the drive");
        }

        foreach (var car in cars)
            Console.WriteLine(car);
    }
}
