namespace Tests;

public class MethodsTests
{
    [Theory]
    [InlineData("Ex001", "2", "The number 2 is positive.")]
    [InlineData("Ex001", "-9", "The number -9 is negative.")]
    [InlineData("Ex001", "0", "The number 0 is zero.")]
    [InlineData("Ex002", "3.33", "Poor")]
    [InlineData("Ex002", "4.50", "Very good")]
    [InlineData("Ex002", "2.99", "Fail")]
    [InlineData("Ex003", "subtract\n5\n4", "1")]
    [InlineData("Ex003", "divide\n8\n4", "2")]
    [InlineData("Ex004", "3", "1\n1 2\n1 2 3\n1 2\n1")]
    [InlineData("Ex004", "2", "1\n1 2\n1")]
    [InlineData("Ex005", "water\n5", "5.00")]
    [InlineData("Ex005", "coffee\n2", "3.00")]
    [InlineData("Ex006", "3\n4", "12")]
    [InlineData("Ex006", "6\n2", "12")]
    [InlineData("Ex007", "abc\n3", "abcabcabc")]
    [InlineData("Ex007", "String\n2", "StringString")]
    [InlineData("Ex008", "2\n8", "256")]
    [InlineData("Ex008", "3\n4", "81")]
    [InlineData("Ex009", "int\n2\n16", "16")]
    [InlineData("Ex009", "char\na\nz", "z")]
    [InlineData("Ex009", "string\naaa\nbbb", "bbb")]
    [InlineData("Ex010", "-12345", "54")]
    [InlineData("Ex010", "3453466", "220")]
    [InlineData("Ex011", "5\n*\n5", "25")]
    [InlineData("Ex011", "4\n+\n8", "12")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
