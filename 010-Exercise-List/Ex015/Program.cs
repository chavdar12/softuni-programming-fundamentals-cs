namespace Ex015;

internal class Program
{
    private static void Main(string[] args)
    {
        var savings = decimal.Parse(Console.ReadLine());
        var initial = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        var drums = initial.ToList();

        string command;
        while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
        {
            var power = int.Parse(command);

            for (var i = 0; i < drums.Count; i++)
            {
                drums[i] -= power;
                if (drums[i] > 0)
                    continue;

                var price = initial[i] * 3;
                if (savings >= price)
                {
                    savings -= price;
                    drums[i] = initial[i];
                }
                else
                {
                    drums.RemoveAt(i);
                    initial.RemoveAt(i);
                    i--;
                }
            }
        }

        Console.WriteLine(string.Join(" ", drums));
        Console.WriteLine($"Gabsy has {savings:f2}lv.");
    }
}
