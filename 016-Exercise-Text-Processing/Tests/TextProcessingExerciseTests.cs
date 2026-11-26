namespace Tests;

public class TextProcessingExerciseTests
{
    [Theory]
    [InlineData("Ex001", "sh, too_long_username, !lleg@l ch@rs, jeffbutt", "jeffbutt")]
    [InlineData("Ex001", "Jeff, john45, ab, cd, peter-ivanov, @smith", "Jeff\njohn45\npeter-ivanov")]
    [InlineData("Ex002", "Peter George", "52114")]
    [InlineData("Ex002", "123 522", "7647")]
    [InlineData("Ex002", "a aaaa", "9700")]
    [InlineData("Ex003", @"C:\Internal\training-internal\Template.pptx", "File name: Template\nFile extension: pptx")]
    [InlineData("Ex003", @"C:\Projects\Data-Structures\LinkedList.cs", "File name: LinkedList\nFile extension: cs")]
    [InlineData("Ex004", "Programming is cool!", "Surjudpplqj#lv#frro$")]
    [InlineData("Ex004", "One year has 365 days.", "Rqh#|hdu#kdv#698#gd|v1")]
    [InlineData("Ex005", "23\n2", "46")]
    [InlineData("Ex005", "9999\n9", "89991")]
    [InlineData("Ex005", "923847238931983192462832102\n4", "3695388955727932769851328408")]
    [InlineData("Ex005", "123\n0", "0")]
    [InlineData("Ex006", "aaaaabbbbbcdddeeeedssaa", "abcdedsa")]
    [InlineData("Ex006", "qqqwerqwecccwd", "qwerqwecwd")]
    [InlineData("Ex007", "abv>1>1>2>2asdasd", "abv>>>>dasd")]
    [InlineData("Ex007", "peter>2sis>1a>2akarate>4hexmaster", "peter>is>a>karate>master")]
    [InlineData("Ex008", "A12b s17G", "330.00")]
    [InlineData("Ex008", "P34562Z q2576f   H456z", "46015.13")]
    [InlineData("Ex008", "a1A", "0.00")]
    [InlineData(
        "Ex009",
        "2\nHere is a name @George| and an age #18*\nAnother name @Billy| #35* is his age",
        "George is 18 years old.\nBilly is 35 years old."
    )]
    [InlineData(
        "Ex009",
        "3\nrandom name @lilly| random digits #5* age\n@Marry| with age #19*\nhere Comes @Garry| he is #48* years old",
        "lilly is 5 years old.\nMarry is 19 years old.\nGarry is 48 years old."
    )]
    [InlineData("Ex010", ".\n@\ndsg12gr5653feee5", "363")]
    [InlineData("Ex010", "?\nE\n@ABCEF", "262")]
    [InlineData(
        "Ex011",
        "1 2 1 3\nikegfp'jpne)bv=41P83X@\nujfufKt)Tkmyft'duEprsfjqbvfv=53V55XA\nfind",
        "Found gold at 10N70W\nFound Silver at 32S43W"
    )]
    [InlineData(
        "Ex012",
        ".. | -- .- -.. . |  -.-- --- ..- | .-- .-. .. - . | .- | .-.. --- -. --. | -.-. --- -.. .",
        "I MADE YOU WRITE A LONG CODE"
    )]
    [InlineData(
        "Ex012",
        ".. | .... --- .--. . | -.-- --- ..- | .- .-. . | -. --- - | -- .- -..",
        "I HOPE YOU ARE NOT MAD"
    )]
    [InlineData(
        "Ex013",
        "SoftUni Article\nSome content of the SoftUni article\nsome comment\nmore comment\nlast comment\nend of comments",
        "<h1>\n    SoftUni Article\n</h1>\n<article>\n    Some content of the SoftUni article\n</article>\n<div>\n    some comment\n</div>\n<div>\n    more comment\n</div>\n<div>\n    last comment\n</div>"
    )]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
