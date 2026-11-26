namespace Ex011;

internal class Program
{
    private static void Main(string[] args)
    {
        var key = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        string line;
        while ((line = Console.ReadLine()) != "find")
        {
            var decrypted = new string(line.Select((c, i) => (char)(c - key[i % key.Length])).ToArray());

            var typeStart = decrypted.IndexOf('&') + 1;
            var type = decrypted.Substring(typeStart, decrypted.IndexOf('&', typeStart) - typeStart);

            var coordinatesStart = decrypted.IndexOf('<') + 1;
            var coordinates = decrypted.Substring(coordinatesStart, decrypted.IndexOf('>') - coordinatesStart);

            Console.WriteLine($"Found {type} at {coordinates}");
        }
    }
}
