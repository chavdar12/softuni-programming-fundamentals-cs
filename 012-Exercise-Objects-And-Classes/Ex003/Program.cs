namespace Ex003;

internal class Article
{
    public string Title { get; set; }

    public string Content { get; set; }

    public string Author { get; set; }

    public override string ToString() => $"{Title} - {Content}: {Author}";
}

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var articles = new List<Article>();

        for (var i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split(", ");
            articles.Add(
                new Article
                {
                    Title = data[0],
                    Content = data[1],
                    Author = data[2],
                }
            );
        }

        var criteria = Console.ReadLine();
        var sorted = criteria switch
        {
            "content" => articles.OrderBy(a => a.Content),
            "author" => articles.OrderBy(a => a.Author),
            _ => articles.OrderBy(a => a.Title),
        };

        foreach (var article in sorted)
            Console.WriteLine(article);
    }
}
