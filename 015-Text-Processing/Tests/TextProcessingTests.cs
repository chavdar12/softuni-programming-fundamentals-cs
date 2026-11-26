namespace Tests;

public class TextProcessingTests
{
    [Theory]
    [InlineData("Ex001", "helLo\nSoftuni\nbottle\nend", "helLo = oLleh\nSoftuni = inutfoS\nbottle = elttob")]
    [InlineData("Ex001", "Dog\ncaT\nchAir\nend", "Dog = goD\ncaT = Tac\nchAir = riAhc")]
    [InlineData("Ex002", "hi abc add", "hihiabcabcabcaddaddadd")]
    [InlineData("Ex002", "work", "workworkworkwork")]
    [InlineData("Ex003", "ice\nkicegiciceeb", "kgb")]
    [InlineData("Ex003", "hep\nShepoftunihepIsGrhepeat", "SoftuniIsGreat")]
    [InlineData(
        "Ex004",
        "Linux, Windows\nIt is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client",
        "It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/*****! Sincerely, a ******* client"
    )]
    [InlineData(
        "Ex004",
        "von Richthofen, German, 80 air\nManfred Albrecht Freiherr von Richthofen, known in English as Baron von Richthofen was a fighter pilot with the German Air Force during World War I. He is considered the ace-of-aces of the war, being officially credited with 80 air combat victories.",
        "Manfred Albrecht Freiherr **************, known in English as Baron ************** was a fighter pilot with the ****** Air Force during World War I. He is considered the ace-of-aces of the war, being officially credited with ****** combat victories."
    )]
    [InlineData("Ex005", "Agd#53Dfg^&4F53", "53453\nAgdDfgF\n#^&")]
    [InlineData("Ex005", "So%f94t34U*n&i></37", "943437\nSoftUni\n%*&></")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
