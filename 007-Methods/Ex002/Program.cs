namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var grade = double.Parse(Console.ReadLine());
        PrintGrade(grade);
    }

    private static void PrintGrade(double grade)
    {
        if (grade < 3.00)
            Console.WriteLine("Fail");
        else if (grade < 3.50)
            Console.WriteLine("Poor");
        else if (grade < 4.50)
            Console.WriteLine("Good");
        else if (grade < 5.50)
            Console.WriteLine("Very good");
        else
            Console.WriteLine("Excellent");
    }
}
