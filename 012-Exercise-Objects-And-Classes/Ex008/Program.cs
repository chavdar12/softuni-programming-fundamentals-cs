namespace Ex008;

internal class Employee
{
    public string Name { get; set; }

    public decimal Salary { get; set; }

    public string Department { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var employees = new List<Employee>();

        for (var i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split();
            employees.Add(
                new Employee
                {
                    Name = data[0],
                    Salary = decimal.Parse(data[1]),
                    Department = data[2],
                }
            );
        }

        var best = employees.GroupBy(e => e.Department).OrderByDescending(g => g.Average(e => e.Salary)).First();

        Console.WriteLine($"Highest Average Salary: {best.Key}");
        foreach (var employee in best.OrderByDescending(e => e.Salary))
            Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
    }
}
