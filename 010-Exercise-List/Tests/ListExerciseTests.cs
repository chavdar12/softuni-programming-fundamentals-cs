namespace Tests;

public class ListExerciseTests
{
    [Theory]
    [InlineData("Ex001", "32 54 21 12 4 0 23\n75\nAdd 10\nAdd 0\n30\n10\n75\nend", "72 54 21 12 4 75 23 10 0")]
    [InlineData("Ex002", "1 2 3 4 5 5 5 6\nDelete 5\nInsert 10 1\nDelete 5\nend", "1 10 2 3 4 6")]
    [InlineData(
        "Ex003",
        "4\nAllie is going!\nGeorge is going!\nJohn is not going!\nGeorge is not going!",
        "John is not in the list!\nAllie"
    )]
    [InlineData("Ex003", "2\nTom is going!\nTom is going!", "Tom is already in the list!\nTom")]
    [InlineData("Ex004", "1 23 29 18 43 21 20\nAdd 5\nRemove 5\nShift left 3\nShift left 1\nEnd", "43 20 5 1 23 29 18")]
    [InlineData(
        "Ex004",
        "5 12 42 95 32 1\nInsert 3 0\nRemove 10\nInsert 8 6\nShift right 1\nShift left 2\nEnd",
        "Invalid index\n5 12 42 95 32 8 1 3"
    )]
    [InlineData("Ex005", "1 2 2 4 2 2 2 9\n4 2", "12")]
    [InlineData("Ex006", "20 30 40 50\n10 20 30 40", "First player wins! Sum: 240")]
    [InlineData("Ex006", "10 20 30 40 50\n50 40 30 30 10", "Second player wins! Sum: 50")]
    [InlineData("Ex007", "1 2 3 |4 5 6 |  7  8", "7 8 4 5 6 1 2 3")]
    [InlineData("Ex008", "Ivo Johny Tony Bony Mony\nmerge 0 3\nmerge 3 4\nmerge 0 3\n3:1", "IvoJohnyTonyBonyMony")]
    [InlineData(
        "Ex008",
        "abcd efgh ijkl mnop qrst uvwx yz\nmerge 4 10\ndivide 4 5\n3:1",
        "abcd efgh ijkl mnop qr st uv wx yz"
    )]
    [InlineData("Ex008", "abcdefgh\ndivide 0 3\nmerge -5 100\n3:1", "abcdefgh")]
    [InlineData("Ex008", "abcdefgh\ndivide 0 3\n3:1", "ab cd efgh")]
    [InlineData("Ex009", "4 5 3\n1\n1\n0", "14")]
    [InlineData("Ex009", "5 10 6 3 5\n2\n4\n1\n1\n3\n0\n0", "51")]
    [InlineData(
        "Ex010",
        "Data Types, Objects, Lists\nAdd:Databases\nInsert:Arrays:0\nRemove:Lists\ncourse start",
        "1.Arrays\n2.Data Types\n3.Objects\n4.Databases"
    )]
    [InlineData(
        "Ex010",
        "Arrays, Lists, Methods\nSwap:Arrays:Methods\nExercise:Databases\nSwap:Lists:Databases\nInsert:Arrays:0\ncourse start",
        "1.Methods\n2.Databases\n3.Databases-Exercise\n4.Arrays\n5.Lists"
    )]
    [InlineData("Ex011", "9992 562 8933\nThis is some message for you", "hey")]
    [InlineData("Ex011", "11 2 32 43 331 522 441 2241 711 1821\n69da343n44ge96rous311!", "dangerous!")]
    [InlineData("Ex012", "29 13 9 0 13 0 21 0 14 82 12", "The winner is left with total time: 53.8")]
    [InlineData("Ex012", "26 46 31 43 1 23 44", "The winner is right with total time: 68")]
    [InlineData("Ex013", "T2exs15ti23ng1_3cT1h3e0_Roppe", "TestingTheRope")]
    [InlineData("Ex013", "O{1ne1T2021wf312o13Th111xreve!!@!", "OneTwoThree!!!")]
    [InlineData("Ex013", "this forbidden mess of an age rating 0127504740", "hidden message")]
    [InlineData("Ex014", "1 5 23 64 2 3 34 54 12\n43 23 12 31 54 51 92", "23 23 31 34 43 51")]
    [InlineData("Ex014", "87 30 65 23 39\n41 85 41 72 46 78 10", "46 65 72 78")]
    [InlineData("Ex015", "1000.00\n58 65 33\n11\n12\n18\n10\nHit it again, Gabsy!", "7 14 23\nGabsy has 901.00lv.")]
    [InlineData(
        "Ex015",
        "154.00\n55 111 3 5 8 50\n2\n50\n8\n23\n1\nHit it again, Gabsy!",
        "27 2 4 7\nGabsy has 10.00lv."
    )]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
