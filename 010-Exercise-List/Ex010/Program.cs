namespace Ex010;

internal class Program
{
    private static void Main(string[] args)
    {
        var schedule = Console.ReadLine().Split(", ").ToList();

        string command;
        while ((command = Console.ReadLine()) != "course start")
        {
            var tokens = command.Split(':');
            var lesson = tokens[1];

            switch (tokens[0])
            {
                case "Add":
                    if (!schedule.Contains(lesson))
                        schedule.Add(lesson);
                    break;
                case "Insert":
                    if (!schedule.Contains(lesson))
                        schedule.Insert(int.Parse(tokens[2]), lesson);
                    break;
                case "Remove":
                    schedule.Remove(lesson);
                    schedule.Remove(Exercise(lesson));
                    break;
                case "Swap":
                    Swap(schedule, lesson, tokens[2]);
                    break;
                case "Exercise":
                    if (!schedule.Contains(lesson))
                        schedule.Add(lesson);
                    if (!schedule.Contains(Exercise(lesson)))
                        schedule.Insert(schedule.IndexOf(lesson) + 1, Exercise(lesson));
                    break;
            }
        }

        for (var i = 0; i < schedule.Count; i++)
            Console.WriteLine($"{i + 1}.{schedule[i]}");
    }

    private static void Swap(List<string> schedule, string first, string second)
    {
        if (!schedule.Contains(first) || !schedule.Contains(second))
            return;

        // Pull the exercises out first so they can follow their lessons to the new positions.
        var firstHasExercise = schedule.Remove(Exercise(first));
        var secondHasExercise = schedule.Remove(Exercise(second));

        var firstIndex = schedule.IndexOf(first);
        var secondIndex = schedule.IndexOf(second);
        schedule[firstIndex] = second;
        schedule[secondIndex] = first;

        if (firstHasExercise)
            schedule.Insert(schedule.IndexOf(first) + 1, Exercise(first));
        if (secondHasExercise)
            schedule.Insert(schedule.IndexOf(second) + 1, Exercise(second));
    }

    private static string Exercise(string lesson) => $"{lesson}-Exercise";
}
