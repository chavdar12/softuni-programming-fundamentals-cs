namespace Tests;

public class RegularExpressionsTests
{
    [Theory]
    [InlineData(
        "Ex001",
        "Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson, John Smith, Sam         Smith",
        "Bethany Taylor John Smith"
    )]
    [InlineData(
        "Ex001",
        "Elvis Presley a a C C-Muhammad Ali EE PeterpeterJR-a a xi ban D D bb b b-B B-c c EE-Michael Jackson DD peter smith B B PETER BROWN IVAN DAVIES-",
        "Elvis Presley Muhammad Ali Michael Jackson"
    )]
    [InlineData(
        "Ex002",
        "+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222",
        "+359 2 222 2222, +359-2-222-2222"
    )]
    [InlineData(
        "Ex002",
        "+359 2 234 2324, 359-2-111-9876, +359/8/655/5432, +359-2 222 2222, +359 2-222-2222, +359-2-234-345, +359-2-123-45678, +359-2-222-2222, +359 2 654 1234",
        "+359 2 234 2324, +359-2-222-2222, +359 2 654 1234"
    )]
    [InlineData(
        "Ex003",
        "13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016",
        "Day: 13, Month: Jul, Year: 1928\nDay: 10, Month: Nov, Year: 1934\nDay: 25, Month: Dec, Year: 1937"
    )]
    [InlineData(
        "Ex003",
        "03-Mar-1878, 25/Apr/1915, 31-May-1916, 22/Jun-1941, 25.Dec.1937, 23/09/1973",
        "Day: 03, Month: Mar, Year: 1878\nDay: 25, Month: Apr, Year: 1915\nDay: 31, Month: May, Year: 1916\nDay: 25, Month: Dec, Year: 1937"
    )]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
