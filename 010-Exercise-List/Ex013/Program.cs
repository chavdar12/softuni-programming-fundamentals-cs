namespace Ex013;

internal class Program
{
    private static void Main(string[] args)
    {
        var message = Console.ReadLine();

        var digits = message.Where(char.IsDigit).Select(c => c - '0').ToList();
        var text = new string(message.Where(c => !char.IsDigit(c)).ToArray());

        var result = string.Empty;
        var position = 0;

        for (var i = 0; i < digits.Count; i += 2)
        {
            var take = digits[i];
            var skip = digits[i + 1];

            result += new string(text.Skip(position).Take(take).ToArray());
            position += take + skip;
        }

        Console.WriteLine(result);
    }
}
