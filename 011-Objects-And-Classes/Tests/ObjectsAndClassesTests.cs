namespace Tests;

public class ObjectsAndClassesTests
{
    [Fact]
    public void Ex001_PrintsEveryWordOnce()
    {
        const string input = "Welcome to SoftUni and have fun learning programming";
        var output = ProgramRunner.Run("Ex001", input).Split('\n');
        Assert.Equal(input.Split(' ').Order(), output.Order());
    }

    [Theory]
    [InlineData("Ex002", "5", "120")]
    [InlineData("Ex002", "50", "30414093201713378043612608166064768844377641568960512000000000000")]
    [InlineData(
        "Ex003",
        "3\nfavourite_DownTown_3:14\nfavourite_Kiss_4:16\nfavourite_Smooth Criminal_4:01\nfavourite",
        "DownTown\nKiss\nSmooth Criminal"
    )]
    [InlineData(
        "Ex003",
        "4\nfavourite_DownTown_3:14\nlistenLater_Andalouse_3:24\nfavourite_In To The Night_3:58\nfavourite_Live It Up_3:48\nlistenLater",
        "Andalouse"
    )]
    [InlineData("Ex003", "2\nlike_Replay_3:15\nban_Photoshop_3:48\nall", "Replay\nPhotoshop")]
    [InlineData(
        "Ex004",
        "John Smith 15 Sofia\nPeter Ivanov 14 Plovdiv\nLinda Bridge 16 Sofia\nSimon Stone 12 Varna\nend\nSofia",
        "John Smith is 15 years old.\nLinda Bridge is 16 years old."
    )]
    [InlineData(
        "Ex005",
        "John Smith 15 Sofia\nPeter Ivanov 14 Plovdiv\nPeter Ivanov 25 Plovdiv\nLinda Bridge 16 Sofia\nLinda Bridge 27 Sofia\nSimon Stone 12 Varna\nend\nSofia",
        "John Smith is 15 years old.\nLinda Bridge is 27 years old."
    )]
    [InlineData(
        "Ex005",
        "Anthony Taylor 15 Chicago\nDavid Anderson 16 Washington\nJack Lewis 14 Chicago\nDavid Lee 14 Chicago\nJack Lewis 26 Chicago\nDavid Lee 18 Chicago\nend\nChicago",
        "Anthony Taylor is 15 years old.\nJack Lewis is 26 years old.\nDavid Lee is 18 years old."
    )]
    [InlineData(
        "Ex006",
        "19861519 Dove 15 2.50\n86757035 Butter 7 3.20\n39393891 Orbit 16 1.60\n37741865 Samsung 10 1000\nend",
        "37741865\n-- Samsung - $1000.00: 10\n-- $10000.00\n19861519\n-- Dove - $2.50: 15\n-- $37.50\n39393891\n-- Orbit - $1.60: 16\n-- $25.60\n86757035\n-- Butter - $3.20: 7\n-- $22.40"
    )]
    [InlineData(
        "Ex007",
        "Car/Audi/A3/110\nCar/Maserati/Levante/350\nTruck/Mercedes/Actros/9019\nCar/Porsche/Panamera/375\nend",
        "Cars:\nAudi: A3 - 110hp\nMaserati: Levante - 350hp\nPorsche: Panamera - 375hp\nTrucks:\nMercedes: Actros - 9019kg"
    )]
    [InlineData(
        "Ex007",
        "Car/Subaru/Impreza/152\nCar/Peugeot/307/109\nend",
        "Cars:\nPeugeot: 307 - 109hp\nSubaru: Impreza - 152hp"
    )]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
