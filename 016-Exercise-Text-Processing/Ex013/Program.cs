namespace Ex013;

internal class Program
{
    private static void Main(string[] args)
    {
        PrintTag("h1", Console.ReadLine());
        PrintTag("article", Console.ReadLine());

        string comment;
        while ((comment = Console.ReadLine()) != "end of comments")
            PrintTag("div", comment);
    }

    private static void PrintTag(string tag, string content)
    {
        Console.WriteLine($"<{tag}>");
        Console.WriteLine($"    {content}");
        Console.WriteLine($"</{tag}>");
    }
}
