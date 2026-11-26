namespace Tests;

public class ObjectsAndClassesExerciseTests
{
    [Fact]
    public void Ex001_PrintsRequestedNumberOfMessages()
    {
        var output = ProgramRunner.Run("Ex001", "3").Split('\n');
        Assert.Equal(3, output.Length);
        Assert.All(output, line => Assert.EndsWith(".", line));
    }

    [Theory]
    [InlineData(
        "Ex002",
        "some title, some content, some author\n3\nEdit: better content\nChangeAuthor:  better author\nRename: better title",
        "better title - better content: better author"
    )]
    [InlineData(
        "Ex002",
        "Fight club, love story, Martin Scorsese\n2\nEdit: underground fight club that evolves into much more\nChangeAuthor: Chuck Palahniuk",
        "Fight club - underground fight club that evolves into much more: Chuck Palahniuk"
    )]
    [InlineData(
        "Ex003",
        "2\nScience, planets, Bill\nArticle, content, Johnny\ntitle",
        "Article - content: Johnny\nScience - planets: Bill"
    )]
    [InlineData(
        "Ex003",
        "3\ntitle1, C, author1\ntitle2, B, author2\ntitle3, A, author3\ncontent",
        "title3 - A: author3\ntitle2 - B: author2\ntitle1 - C: author1"
    )]
    [InlineData(
        "Ex004",
        "4\nLakia Eason 3.90\nPrince Messing 5.49\nAkiko Segers 4.85\nRocco Erben 6.00",
        "Rocco Erben: 6.00\nPrince Messing: 5.49\nAkiko Segers: 4.85\nLakia Eason: 3.90"
    )]
    [InlineData(
        "Ex005",
        "2\nJohn-PowerPuffsCoders\nTony-Tony is the best\nPeter->PowerPuffsCoders\nTony->Tony is the best\nend of assignment",
        "Team PowerPuffsCoders has been created by John!\nTeam Tony is the best has been created by Tony!\nMember Tony cannot join team Tony is the best!\nPowerPuffsCoders\n- John\n-- Peter\nTeams to disband:\nTony is the best"
    )]
    [InlineData(
        "Ex005",
        "3\nTanya-CloneClub\nHelena-CloneClub\nTedy-SoftUni\nGeorge->softUni\nGeorge->SoftUni\nTatyana->Leda\nJohn->SoftUni\nCossima->CloneClub\nend of assignment",
        "Team CloneClub has been created by Tanya!\nTeam CloneClub was already created!\nTeam SoftUni has been created by Tedy!\nTeam softUni does not exist!\nTeam Leda does not exist!\nSoftUni\n- Tedy\n-- George\n-- John\nCloneClub\n- Tanya\n-- Cossima\nTeams to disband:"
    )]
    [InlineData(
        "Ex006",
        "truck Man red 200\ntruck Mercedes blue 300\ncar Ford green 120\ncar Ferrari red 550\ncar Lamborghini orange 570\nEnd\nFerrari\nFord\nMan\nClose the Catalogue",
        "Type: Car\nModel: Ferrari\nColor: red\nHorsepower: 550\nType: Car\nModel: Ford\nColor: green\nHorsepower: 120\nType: Truck\nModel: Man\nColor: red\nHorsepower: 200\nCars have average horsepower of: 413.33.\nTrucks have average horsepower of: 250.00."
    )]
    [InlineData(
        "Ex007",
        "George 123456 20\nPeter 78911 15\nStephen 524244 10\nEnd",
        "Stephen with ID: 524244 is 10 years old.\nPeter with ID: 78911 is 15 years old.\nGeorge with ID: 123456 is 20 years old."
    )]
    [InlineData(
        "Ex007",
        "Lewis 123456 20\nJames 78911 15\nRobert 523444 11\nJennifer 345244 13\nMary 52424678 22\nPatricia 567343 54\nEnd",
        "Robert with ID: 523444 is 11 years old.\nJennifer with ID: 345244 is 13 years old.\nJames with ID: 78911 is 15 years old.\nLewis with ID: 123456 is 20 years old.\nMary with ID: 52424678 is 22 years old.\nPatricia with ID: 567343 is 54 years old."
    )]
    [InlineData(
        "Ex008",
        "4\nPeter 120.00 Development\nTony 333.33 Marketing\nJony 840.20 Development\nGeorge 0.20 Nowhere",
        "Highest Average Salary: Development\nJony 840.20\nPeter 120.00"
    )]
    [InlineData(
        "Ex008",
        "6\nSuny 496.37 Coding\nJohny 610.13 Sales\nTeo 609.99 Sales\nVlady 0.02 BeerDrinking\nAndrey 700.00 Coding\nPopeye 13.3333 SpinachGroup",
        "Highest Average Salary: Sales\nJohny 610.13\nTeo 609.99"
    )]
    [InlineData("Ex009", "3\nPeter 3\nGeorge 4\nAnnie 5", "Annie 5")]
    [InlineData("Ex009", "5\nSteve 10\nChristopher 15\nJohn 35\nAnnie 4\nMaria 34", "John 35")]
    [InlineData(
        "Ex010",
        "2\nAudiA4 23 0.3\nBMW-M2 45 0.42\nDrive BMW-M2 56\nDrive AudiA4 5\nDrive AudiA4 13\nEnd",
        "AudiA4 17.60 18\nBMW-M2 21.48 56"
    )]
    [InlineData(
        "Ex010",
        "3\nAudiA4 18 0.34\nBMW-M2 33 0.41\nFerrari-488Spider 50 0.47\nDrive Ferrari-488Spider 97\nDrive Ferrari-488Spider 35\nDrive AudiA4 85\nDrive AudiA4 50\nEnd",
        "Insufficient fuel for the drive\nInsufficient fuel for the drive\nAudiA4 1.00 50\nBMW-M2 33.00 0\nFerrari-488Spider 4.41 97"
    )]
    [InlineData(
        "Ex011",
        "2\nChevroletAstro 200 180 1000 fragile\nCitroen2CV 190 165 900 fragile\nfragile",
        "Citroen2CV"
    )]
    [InlineData(
        "Ex011",
        "4\nChevroletExpress 215 255 1200 flamable\nChevroletAstro 210 230 1000 flamable\nDaciaDokker 230 275 1400 flamable\nCitroen2CV 190 165 1200 fragile\nflamable",
        "ChevroletExpress\nDaciaDokker"
    )]
    [InlineData(
        "Ex012",
        "Peter=11;George=4\nBread=10;Milk=2;\nPeter Bread\nGeorge Milk\nGeorge Milk\nPeter Milk\nEND",
        "Peter bought Bread\nGeorge bought Milk\nGeorge bought Milk\nPeter can't afford Milk\nPeter - Bread\nGeorge - Milk, Milk"
    )]
    [InlineData("Ex012", "Maria=0\nCoffee=2\nMaria Coffee\nEND", "Maria can't afford Coffee\nMaria - Nothing bought")]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
