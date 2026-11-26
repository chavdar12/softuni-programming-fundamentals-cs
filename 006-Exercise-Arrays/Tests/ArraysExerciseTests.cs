namespace Tests;

public class ArraysExerciseTests
{
    [Theory]
    [InlineData("Ex001", "3\n1\n2\n3", "1 2 3\n6")]
    [InlineData("Ex002", "Hey hello 2 4\n10 hey 4 hello", "4 hello")]
    [InlineData("Ex003", "4\n1 5\n9 10\n31 81\n41 20", "1 10 31 20\n5 9 81 41")]
    [InlineData("Ex004", "51 47 32 61 21\n2", "32 61 21 51 47")]
    [InlineData("Ex005", "1 4 3 2", "4 3 2")]
    [InlineData("Ex005", "14 24 3 19 15 17", "24 19 17")]
    [InlineData("Ex006", "1 2 3 3", "2")]
    [InlineData("Ex006", "1 2", "no")]
    [InlineData("Ex006", "1", "0")]
    [InlineData("Ex007", "2 1 1 2 3 3 2 2 2 1", "2 2 2")]
    [InlineData("Ex007", "1 1 1 2 3 1 3 3", "1 1 1")]
    [InlineData("Ex007", "4 4 4 4", "4 4 4 4")]
    [InlineData("Ex008", "1 7 6 2 19 23\n8", "1 7\n6 2")]
    [InlineData("Ex009", "5\n1!0!1!1!0\n0!1!1!0!0\nClone them!", "Best DNA sample 2 with sum: 2.\n0 1 1 0 0")]
    [InlineData("Ex010", "3\n0 1\n0 right 1\n2 right 1\nend", "0 1 0")]
    [InlineData("Ex010", "3\n0 1 2\n0 right 1\n1 right 1\n2 right 1\nend", "0 0 0")]
    [InlineData("Ex011", "4\nPeter\nMaria\nKatya\nTodor", "1032\n1071\n1168\n1532")]
    [InlineData("Ex011", "3\nSofia\nLondon\nWashington", "1396\n1601\n3202")]
    [InlineData("Ex012", "4", "1\n1 1\n1 2 1\n1 3 3 1")]
    [InlineData("Ex013", "5", "5")]
    [InlineData("Ex013", "21", "10946")]
    [InlineData("Ex013", "50", "12586269025")]
    [InlineData("Ex014", "5 2 3 6", "7 9")]
    [InlineData("Ex014", "1 2 3 4 5 6 7 8", "5 5 13 13")]
    [InlineData("Ex014", "4 3 -1 2 5 0 1 9 8 6 7 -2", "1 8 4 -1 16 14")]
    [InlineData("Ex015", "1", "1")]
    [InlineData("Ex015", "7 3 5 8 -1 0 6 7", "3 5 6 7")]
    [InlineData("Ex015", "1 2 5 3 5 2 4 1", "1 2 3 5")]
    [InlineData("Ex015", "0 10 20 30 30 40 1 50 2 3 4 5 6", "0 1 2 3 4 5 6")]
    [InlineData("Ex015", "11 12 13 3 14 4 15 5 6 7 8 7 16 9 8", "3 4 5 6 7 8 16")]
    [InlineData("Ex015", "3 14 5 12 15 7 8 9 11 10 1", "3 5 7 8 9 11")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
