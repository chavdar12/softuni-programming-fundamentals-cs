namespace Ex012;

internal class Program
{
    private static readonly Dictionary<string, char> Morse = new()
    {
        { ".-", 'A' },
        { "-...", 'B' },
        { "-.-.", 'C' },
        { "-..", 'D' },
        { ".", 'E' },
        { "..-.", 'F' },
        { "--.", 'G' },
        { "....", 'H' },
        { "..", 'I' },
        { ".---", 'J' },
        { "-.-", 'K' },
        { ".-..", 'L' },
        { "--", 'M' },
        { "-.", 'N' },
        { "---", 'O' },
        { ".--.", 'P' },
        { "--.-", 'Q' },
        { ".-.", 'R' },
        { "...", 'S' },
        { "-", 'T' },
        { "..-", 'U' },
        { "...-", 'V' },
        { ".--", 'W' },
        { "-..-", 'X' },
        { "-.--", 'Y' },
        { "--..", 'Z' },
        { "|", ' ' },
    };

    private static void Main(string[] args)
    {
        var codes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(new string(codes.Select(code => Morse[code]).ToArray()));
    }
}
