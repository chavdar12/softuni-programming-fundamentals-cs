namespace Ex002;

internal class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; private set; }

    public string Content { get; private set; }

    public string Author { get; private set; }

    public void Edit(string content) => Content = content;

    public void ChangeAuthor(string author) => Author = author;

    public void Rename(string title) => Title = title;

    public override string ToString() => $"{Title} - {Content}: {Author}";
}

internal class Program
{
    private static void Main(string[] args)
    {
        var data = Console.ReadLine().Split(", ");
        var article = new Article(data[0], data[1], data[2]);

        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var command = Console.ReadLine().Split(':', 2);
            var value = command[1].Trim();

            switch (command[0])
            {
                case "Edit":
                    article.Edit(value);
                    break;
                case "ChangeAuthor":
                    article.ChangeAuthor(value);
                    break;
                case "Rename":
                    article.Rename(value);
                    break;
            }
        }

        Console.WriteLine(article);
    }
}
