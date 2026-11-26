namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var type = Console.ReadLine();
        var first = Console.ReadLine();
        var second = Console.ReadLine();

        switch (type)
        {
            case "int":
                Console.WriteLine(GetMax(int.Parse(first), int.Parse(second)));
                break;
            case "char":
                Console.WriteLine(GetMax(char.Parse(first), char.Parse(second)));
                break;
            case "string":
                Console.WriteLine(GetMax(first, second));
                break;
        }
    }

    private static int GetMax(int first, int second) => Math.Max(first, second);

    private static char GetMax(char first, char second) => first > second ? first : second;

    private static string GetMax(string first, string second) =>
        string.CompareOrdinal(first, second) > 0 ? first : second;
}
