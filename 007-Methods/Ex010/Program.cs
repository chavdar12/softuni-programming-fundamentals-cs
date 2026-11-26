namespace Ex010;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = Math.Abs(int.Parse(Console.ReadLine()));
        Console.WriteLine(GetMultipleOfEvenAndOdds(number));
    }

    private static int GetMultipleOfEvenAndOdds(int number) => GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);

    private static int GetSumOfEvenDigits(int number) => GetDigits(number).Where(d => d % 2 == 0).Sum();

    private static int GetSumOfOddDigits(int number) => GetDigits(number).Where(d => d % 2 != 0).Sum();

    private static IEnumerable<int> GetDigits(int number) => number.ToString().Select(c => c - '0');
}
