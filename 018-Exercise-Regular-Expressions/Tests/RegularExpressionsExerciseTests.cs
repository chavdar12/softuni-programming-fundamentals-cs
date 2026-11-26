namespace Tests;

public class RegularExpressionsExerciseTests
{
    [Theory]
    [InlineData(
        "Ex001",
        ">>Sofa<<312.23!3\n>>TV<<300!5\n>Invalid<<!5\nPurchase",
        "Bought furniture:\nSofa\nTV\nTotal money spend: 2436.69"
    )]
    [InlineData(
        "Ex001",
        ">>Chair<<412.23!3\n>>Sofa<<500!5\n>>Recliner<<<<!5\n>>Bench<<230!10\n>>>>>>Rocking chair<<!5\n>>Bed<<700!5\nPurchase",
        "Bought furniture:\nChair\nSofa\nBench\nBed\nTotal money spend: 9536.69"
    )]
    [InlineData(
        "Ex002",
        "George, Peter, Bill, Tom\nG4e@55or%6g6!68e!!@\nR1@!3a$y4456@\nB5@i@#123ll\nG@e54o$r6ge#\n7P%et^#e5346r\nT$o553m&6\nend of race",
        "1st place: George\n2nd place: Peter\n3rd place: Tom"
    )]
    [InlineData(
        "Ex002",
        "Ivan, Peter, James, Kyle\nI4v@43an%66?77!!@\nG1@!3u$s445s6@\nB3@i@#245ll\nI&v54a%66n@\n7P%et^#e5346r\nJ$a553m&e6s\nK2y3=l/^e23\nend of race",
        "1st place: Ivan\n2nd place: Peter\n3rd place: James"
    )]
    [InlineData(
        "Ex003",
        "%George%<Croissant>|2|10.3$\n%Peter%<Gum>|1|1.3$\n%Maria%<Cola>|1|2.4$\nend of shift",
        "George: Croissant - 20.60\nPeter: Gum - 1.30\nMaria: Cola - 2.40\nTotal income: 24.30"
    )]
    [InlineData(
        "Ex003",
        "%InvalidName%<Croissant>|2|10.3$\n%Peter%<Gum>1.3$\n%Maria%<Cola>|1|2.4\n%Valid%<Valid>valid|10|valid20$\nend of shift",
        "Valid: Valid - 200.00\nTotal income: 200.00"
    )]
    [InlineData(
        "Ex004",
        "2\nSTCDoghudd4=63333$D$0A53333\nEHfsytsnhf?8555&I&2C9555SR",
        "Attacked planets: 1\n-> Alderaa\nDestroyed planets: 1\n-> Cantonica"
    )]
    [InlineData(
        "Ex004",
        "3\ntt(''DGsvywgerx>6444444444%H%1B9444\nGQhrr|A977777(H(TTTT\nEHfsytsnhf?8555&I&2C9555SR",
        "Attacked planets: 0\nDestroyed planets: 2\n-> Cantonica\n-> Coruscant"
    )]
    [InlineData("Ex005", "M3ph-0.5s-0.5t0.0**", "M3ph-0.5s-0.5t0.0** - 524 health, 8.00 damage")]
    [InlineData(
        "Ex005",
        "M3ph1st0**, Azazel",
        "Azazel - 615 health, 0.00 damage\nM3ph1st0** - 524 health, 16.00 damage"
    )]
    [InlineData("Ex005", "Gos/ho", "Gos/ho - 512 health, 0.00 damage")]
    [InlineData("Ex006", "Please contact us at: support@github.com.", "support@github.com")]
    [InlineData(
        "Ex006",
        "Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.",
        "s.miller@mit.edu\nj.hopking@york.ac.uk"
    )]
    [InlineData("Ex006", "Bad ones: --123@gmail.com _steve@yahoo.cn mike@helloworld", "")]
    [InlineData("Ex007", "Cash$$$$$$Ca$$$$$$sh", "ticket \"Cash$$$$$$Ca$$$$$$sh\" - 6$")]
    [InlineData(
        "Ex007",
        "$$$$$$$$$$$$$$$$$$$$, aabb  , th@@@@@@eemo@@@@@@ey",
        "ticket \"$$$$$$$$$$$$$$$$$$$$\" - 10$ Jackpot!\ninvalid ticket\nticket \"th@@@@@@eemo@@@@@@ey\" - 6@"
    )]
    [InlineData("Ex007", "validticketnomatch:(", "ticket \"validticketnomatch:(\" - no match")]
    [InlineData("Ex008", "a3", "Unique symbols used: 1\nAAA")]
    [InlineData("Ex008", "aSd2&5s@1", "Unique symbols used: 5\nASDASD&&&&&S@")]
    [InlineData(
        "Ex009",
        "sdsGGasAOTPWEEEdas$AOTP$|a65:1.2s65:03d79:01ds84:02! -80:07++ABs90:1.1|adsaArmyd Gara So La Arm Armyw21 Argo O daOfa Or Ti Sar saTheww The Parahaos",
        "Argo\nOr\nThe\nParahaos"
    )]
    [InlineData(
        "Ex009",
        "Urgent\"Message.TO$#POAML#|readData79:05:79:0!2reme80:03--23:11{79:05}tak{65:11ar}!77:!23--)77:05ACCSS76:05ad|Remedy Por Ostream :Istream Post sOffices Office Of Ankh-Morpork MR.LIPWIG Mister Lipwig",
        "Post\nOffice\nAnkh-Morpork\nMister\nLipwig"
    )]
    [InlineData("Ex010", "3\nCNdwhamigyenumje$J$\nCEreelh-nmguuejn$J$\nCVwdq&gnmjkvng$Q$\nend", "Kate\nBobbie")]
    [InlineData(
        "Ex010",
        "3\nN}eideidmk$'(mnyenmCNlpamnin$J$\nddddkkkkmvkvmCFrqqru-nvevek$J$nmgievnge\nppqmkkkmnolmnnCEhq/vkievk$Q$\nyyegiivoguCYdohqwlqh/kguimhk$J$\nend",
        "Kim\nConnor\nValentine"
    )]
    public void Program_PrintsExpectedOutput(string exercise, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(exercise, input));
}
