using System.Reflection;

// Programs swap the global Console.In/Out, so tests must never run concurrently.
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace Tests;

/// <summary>
/// Runs an exercise's Main (every ExNNN project is referenced by this project) with redirected console I/O.
/// </summary>
public static class ProgramRunner
{
    /// <param name="exercise">Exercise project name, e.g. "Ex001".</param>
    /// <returns>Console output with "\n" line endings and trailing whitespace trimmed from every line.</returns>
    public static string Run(string exercise, string input = "")
    {
        var entryPoint = Assembly.Load(exercise).EntryPoint!;

        var originalIn = Console.In;
        var originalOut = Console.Out;
        var output = new StringWriter();

        try
        {
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);
            entryPoint.Invoke(null, entryPoint.GetParameters().Length == 0 ? null : [Array.Empty<string>()]);
        }
        finally
        {
            Console.SetIn(originalIn);
            Console.SetOut(originalOut);
        }

        var lines = output.ToString().ReplaceLineEndings("\n").Split('\n').Select(line => line.TrimEnd());
        return string.Join("\n", lines).TrimEnd('\n');
    }
}
