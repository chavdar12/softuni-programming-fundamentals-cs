namespace Ex004;

internal class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }

    public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";
}

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var students = new List<Student>();

        for (var i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split();
            students.Add(
                new Student
                {
                    FirstName = data[0],
                    LastName = data[1],
                    Grade = double.Parse(data[2]),
                }
            );
        }

        foreach (var student in students.OrderByDescending(s => s.Grade))
            Console.WriteLine(student);
    }
}
