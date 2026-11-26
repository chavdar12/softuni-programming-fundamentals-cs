namespace Tests;

public class AssociativeArraysTests
{
    [Theory]
    [InlineData("Ex001", "8 2 2 8 2", "2 -> 3\n8 -> 2")]
    [InlineData("Ex001", "1 5 1 3", "1 -> 2\n3 -> 1\n5 -> 1")]
    [InlineData("Ex001", "-2 0 0 2", "-2 -> 1\n0 -> 2\n2 -> 1")]
    [InlineData("Ex002", "Java C# PHP PHP JAVA C java", "java c# c")]
    [InlineData("Ex002", "3 5 5 hi pi HO Hi 5 ho 3 hi pi", "5 hi")]
    [InlineData("Ex002", "a a A SQL xx a xx a A a XX c", "a sql xx c")]
    [InlineData(
        "Ex003",
        "3\ncute\nadorable\ncute\ncharming\nsmart\nclever",
        "cute - adorable, charming\nsmart - clever"
    )]
    [InlineData("Ex003", "2\ntask\nproblem\ntask\nassignment", "task - problem, assignment")]
    [InlineData("Ex004", "10 30 15 20 50 5", "50 30 20")]
    [InlineData("Ex004", "20 30", "30 20")]
    [InlineData("Ex005", "kiwi orange banana apple", "kiwi\norange\nbanana")]
    [InlineData("Ex005", "pizza cake pasta chips", "cake")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
