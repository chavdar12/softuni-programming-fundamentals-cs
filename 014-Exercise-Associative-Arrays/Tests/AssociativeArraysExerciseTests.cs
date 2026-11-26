namespace Tests;

public class AssociativeArraysExerciseTests
{
    [Theory]
    [InlineData("Ex001", "text", "t -> 2\ne -> 1\nx -> 1")]
    [InlineData("Ex001", "text text text", "t -> 6\ne -> 3\nx -> 3")]
    [InlineData("Ex002", "Gold\n155\nSilver\n10\nCopper\n17\nstop", "Gold -> 155\nSilver -> 10\nCopper -> 17")]
    [InlineData(
        "Ex002",
        "gold\n155\nsilver\n10\ncopper\n17\ngold\n15\nstop",
        "gold -> 170\nsilver -> 10\ncopper -> 17"
    )]
    [InlineData(
        "Ex003",
        "3 Motes 5 stones 5 Shards\n6 leathers 255 fragments 7 Shards",
        "Valanyr obtained!\nfragments: 5\nshards: 5\nmotes: 3\nleathers: 6\nstones: 5"
    )]
    [InlineData(
        "Ex003",
        "123 silver 6 shards 8 shards 5 motes\n9 fangs 75 motes 103 MOTES 8 Shards\n86 Motes 7 stones 19 silver",
        "Dragonwrath obtained!\nshards: 22\nmotes: 19\nfragments: 0\nfangs: 9\nsilver: 123"
    )]
    [InlineData(
        "Ex004",
        "Beer 2.20 100\nIceTea 1.50 50\nNukaCola 3.30 80\nWater 1.00 500\nbuy",
        "Beer -> 220.00\nIceTea -> 75.00\nNukaCola -> 264.00\nWater -> 500.00"
    )]
    [InlineData(
        "Ex004",
        "Beer 2.40 350\nWater 1.25 200\nIceTea 5.20 100\nBeer 1.20 200\nIceTea 0.50 120\nbuy",
        "Beer -> 660.00\nWater -> 250.00\nIceTea -> 110.00"
    )]
    [InlineData(
        "Ex004",
        "CesarSalad 10.20 25\nSuperEnergy 0.80 400\nBeer 1.35 350\nIceCream 1.50 25\nbuy",
        "CesarSalad -> 255.00\nSuperEnergy -> 320.00\nBeer -> 472.50\nIceCream -> 37.50"
    )]
    [InlineData(
        "Ex005",
        "5\nregister John CS1234JS\nregister George JAVA123S\nregister Andy AB4142CD\nregister Jesica VR1223EE\nunregister Andy",
        "John registered CS1234JS successfully\nGeorge registered JAVA123S successfully\nAndy registered AB4142CD successfully\nJesica registered VR1223EE successfully\nAndy unregistered successfully\nJohn => CS1234JS\nGeorge => JAVA123S\nJesica => VR1223EE"
    )]
    [InlineData(
        "Ex005",
        "4\nregister Jony AA4132BB\nregister Jony AA4132BB\nregister Linda AA9999BB\nunregister Jony",
        "Jony registered AA4132BB successfully\nERROR: already registered with plate number AA4132BB\nLinda registered AA9999BB successfully\nJony unregistered successfully\nLinda => AA9999BB"
    )]
    [InlineData(
        "Ex005",
        "6\nregister Jacob MM1111XX\nregister Anthony AB1111XX\nunregister Jacob\nregister Joshua DD1111XX\nunregister Lily\nregister Samantha AA9999BB",
        "Jacob registered MM1111XX successfully\nAnthony registered AB1111XX successfully\nJacob unregistered successfully\nJoshua registered DD1111XX successfully\nERROR: user Lily not found\nSamantha registered AA9999BB successfully\nJoshua => DD1111XX\nAnthony => AB1111XX\nSamantha => AA9999BB"
    )]
    [InlineData(
        "Ex006",
        "Programming Fundamentals : John Smith\nProgramming Fundamentals : Linda Johnson\nJS Core : Will Wilson\nJava Advanced : Harrison White\nend",
        "Programming Fundamentals: 2\n-- John Smith\n-- Linda Johnson\nJS Core: 1\n-- Will Wilson\nJava Advanced: 1\n-- Harrison White"
    )]
    [InlineData(
        "Ex006",
        "Algorithms : Jay Moore\nProgramming Basics : Martin Taylor\nPython Fundamentals : John Anderson\nPython Fundamentals : Andrew Robinson\nAlgorithms : Bob Jackson\nPython Fundamentals : Clark Lewis\nend",
        "Python Fundamentals: 3\n-- Andrew Robinson\n-- Clark Lewis\n-- John Anderson\nAlgorithms: 2\n-- Bob Jackson\n-- Jay Moore\nProgramming Basics: 1\n-- Martin Taylor"
    )]
    [InlineData(
        "Ex007",
        "5\nJohn\n5.5\nJohn\n4.5\nAlice\n6\nAlice\n3\nGeorge\n5",
        "John -> 5.00\nGeorge -> 5.00\nAlice -> 4.50"
    )]
    [InlineData(
        "Ex007",
        "5\nAmanda\n3.5\nAmanda\n4\nRob\n5.5\nChristian\n5\nRobert\n6",
        "Robert -> 6.00\nRob -> 5.50\nChristian -> 5.00"
    )]
    [InlineData(
        "Ex008",
        "SoftUni -> AA12345\nSoftUni -> BB12345\nMicrosoft -> CC12345\nHP -> BB12345\nEnd",
        "HP\n-- BB12345\nMicrosoft\n-- CC12345\nSoftUni\n-- AA12345\n-- BB12345"
    )]
    [InlineData(
        "Ex008",
        "SoftUni -> AA12345\nSoftUni -> CC12344\nLenovo -> XX23456\nSoftUni -> AA12345\nMovement -> DD11111\nEnd",
        "Lenovo\n-- XX23456\nMovement\n-- DD11111\nSoftUni\n-- AA12345\n-- CC12344"
    )]
    [InlineData(
        "Ex009",
        "Light | George\nDark | Peter\nLumpawaroo",
        "Side: Dark, Members: 1\n! Peter\nSide: Light, Members: 1\n! George"
    )]
    [InlineData(
        "Ex009",
        "Lighter | Royal\nDarker | DCay\nJohn Johnys -> Lighter\nDCay -> Lighter\nLumpawaroo",
        "John Johnys joins the Lighter side!\nDCay joins the Lighter side!\nSide: Lighter, Members: 3\n! DCay\n! John Johnys\n! Royal"
    )]
    [InlineData(
        "Ex010",
        "Peter-Java-84\nGeorge-C#-70\nGeorge-C#-84\nSam-C#-94\nexam finished",
        "Results:\nSam | 94\nGeorge | 84\nPeter | 84\nSubmissions:\nC# - 3\nJava - 1"
    )]
    [InlineData(
        "Ex010",
        "Peter-Java-91\nGeorge-C#-84\nSam-JavaScript-90\nSam-C#-50\nSam-banned\nexam finished",
        "Results:\nPeter | 91\nGeorge | 84\nSubmissions:\nC# - 2\nJava - 1\nJavaScript - 1"
    )]
    [InlineData(
        "Ex011",
        "Part One Interview:success\nJs Fundamentals:Jsfundmpass\nC# Fundamentals:fundPass\nAlgorithms:fun\nend of contests\nC# Fundamentals=>fundPass=>Tanya=>350\nAlgorithms=>fun=>Tanya=>380\nPart One Interview=>success=>Nikola=>120\nJava Basics Exam=>jsfundmpass=>Mary=>400\nPart One Interview=>success=>Tanya=>220\nOOP Advanced=>password123=>Jim=>231\nC# Fundamentals=>fundPass=>Tanya=>250\nC# Fundamentals=>fundPass=>Nikola=>200\nJs Fundamentals=>Jsfundmpass=>Tanya=>400\nend of submissions",
        "Best candidate is Tanya with total 1350 points.\nRanking:\nNikola\n#  C# Fundamentals -> 200\n#  Part One Interview -> 120\nTanya\n#  Js Fundamentals -> 400\n#  Algorithms -> 380\n#  C# Fundamentals -> 350\n#  Part One Interview -> 220"
    )]
    [InlineData(
        "Ex011",
        "Java Advanced:funpass\nPart Two Interview:success\nMath Concept:asdasd\nJava Web Basics:forrF\nend of contests\nMath Concept=>ispass=>Mona=>290\nJava Advanced=>funpass=>Simon=>400\nPart Two Interview=>success=>Derek=>120\nJava Advanced=>funpass=>Peter=>90\nJava Web Basics=>forrF=>Simon=>280\nPart Two Interview=>success=>Peter=>0\nMath Concept=>asdasd=>Derek=>250\nPart Two Interview=>success=>Simon=>200\nend of submissions",
        "Best candidate is Simon with total 880 points.\nRanking:\nDerek\n#  Math Concept -> 250\n#  Part Two Interview -> 120\nPeter\n#  Java Advanced -> 90\n#  Part Two Interview -> 0\nSimon\n#  Java Advanced -> 400\n#  Java Web Basics -> 280\n#  Part Two Interview -> 200"
    )]
    [InlineData(
        "Ex012",
        "Peter -> Algo -> 400\nGeorge -> Algo -> 300\nSam -> Algo -> 200\nPeter -> DS -> 150\nMaria -> DS -> 600\nno more time",
        "Algo: 3 participants\n1. Peter <::> 400\n2. George <::> 300\n3. Sam <::> 200\nDS: 2 participants\n1. Maria <::> 600\n2. Peter <::> 150\nIndividual standings:\n1. Maria -> 600\n2. Peter -> 550\n3. George -> 300\n4. Sam -> 200"
    )]
    [InlineData(
        "Ex012",
        "Peter -> OOP -> 350\nGeorge -> OOP -> 250\nSam -> Advanced -> 600\nGeorge -> OOP -> 300\nJohn -> OOP -> 300\nJohn -> Advanced -> 250\nAnna -> JSCore -> 400\nno more time",
        "OOP: 3 participants\n1. Peter <::> 350\n2. George <::> 300\n3. John <::> 300\nAdvanced: 2 participants\n1. Sam <::> 600\n2. John <::> 250\nJSCore: 1 participants\n1. Anna <::> 400\nIndividual standings:\n1. Sam -> 600\n2. John -> 550\n3. Anna -> 400\n4. Peter -> 350\n5. George -> 300"
    )]
    [InlineData(
        "Ex013",
        "Peter -> Adc -> 400\nGeorge -> Jungle -> 300\nSam -> Mid -> 200\nSam -> Support -> 250\nSeason end",
        "Sam: 450 skill\n- Support <::> 250\n- Mid <::> 200\nPeter: 400 skill\n- Adc <::> 400\nGeorge: 300 skill\n- Jungle <::> 300"
    )]
    [InlineData(
        "Ex013",
        "Peter -> Adc -> 400\nBush -> Tank -> 150\nFaker -> Mid -> 200\nFaker -> Support -> 250\nFaker -> Tank -> 250\nPeter vs Faker\nFaker vs Bush\nFaker vs Hide\nSeason end",
        "Faker: 700 skill\n- Support <::> 250\n- Tank <::> 250\n- Mid <::> 200\nPeter: 400 skill\n- Adc <::> 400"
    )]
    [InlineData(
        "Ex014",
        "Peter <:> Red <:> 2000\nTony <:> Blue <:> 1000\nGeorge <:> Green <:> 1000\nSam <:> Yellow <:> 4500\nJohn <:> Black <:> 1000\nOnce upon a time",
        "(Yellow) Sam <-> 4500\n(Red) Peter <-> 2000\n(Blue) Tony <-> 1000\n(Green) George <-> 1000\n(Black) John <-> 1000"
    )]
    [InlineData(
        "Ex014",
        "Peter <:> Red <:> 5000\nPeter <:> Blue <:> 10000\nPeter <:> Red <:> 10000\nGeorge <:> Blue <:> 10000\nOnce upon a time",
        "(Blue) Peter <-> 10000\n(Blue) George <-> 10000\n(Red) Peter <-> 10000"
    )]
    [InlineData(
        "Ex015",
        "5\nRed Bazgargal 100 2500 25\nBlack Dargonax 200 3500 18\nRed Obsidion 220 2200 35\nBlue Kerizsa 60 2100 20\nBlue Algordox 65 1800 50",
        "Red::(160.00/2350.00/30.00)\n-Bazgargal -> damage: 100, health: 2500, armor: 25\n-Obsidion -> damage: 220, health: 2200, armor: 35\nBlack::(200.00/3500.00/18.00)\n-Dargonax -> damage: 200, health: 3500, armor: 18\nBlue::(62.50/1950.00/35.00)\n-Algordox -> damage: 65, health: 1800, armor: 50\n-Kerizsa -> damage: 60, health: 2100, armor: 20"
    )]
    [InlineData(
        "Ex015",
        "4\nGold Zzazx null 1000 10\nGold Traxx 500 null 0\nGold Xaarxx 250 1000 null\nGold Ardrax 100 1055 50",
        "Gold::(223.75/826.25/17.50)\n-Ardrax -> damage: 100, health: 1055, armor: 50\n-Traxx -> damage: 500, health: 250, armor: 0\n-Xaarxx -> damage: 250, health: 1000, armor: 10\n-Zzazx -> damage: 45, health: 1000, armor: 10"
    )]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
