//Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Console.Clear();
Console.WriteLine("""
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.
""");

Console.Write("Vad heter du? ");
string namn = Console.ReadLine()!;

//Programloop
while (true)
{
    Console.Write("Ange din bruttolön i kronor: ");
    int brutto = int.Parse(Console.ReadLine()!);

    //Kontrollera om brutto lönen är ett tal mellan 10,000 & 1,000,000
    if (brutto < 10000 || brutto > 1000000)
    {
        Console.WriteLine($"{namn} Bruttolönet måste vara mellan 10 000 och 1 000 000");
    }
    else
    {
        // 10000 till 450000 = 22%
        int skattesatsen = 0;
        if (brutto >= 10000 && brutto < 145000)
        {
            skattesatsen = 22;
        }
        // 145000 till 515000 = 35%
        if (brutto >= 145000 && brutto < 515000)
        {
            skattesatsen = 35;
        }
        // 515000 eller mer = 53%
        if (brutto >= 515000)
        {
            skattesatsen = 53;
        }

        //Skatteuträkning
        int netto = brutto * (100 - skattesatsen) / 100;

        //Fedback till användaren, resultatet
        Console.WriteLine($"Din nettolön blir {netto} kr. Utreäkning baserad på bruttolön {brutto} kr och marginalskatten {skattesatsen}%. ");
    }

    //Vill du göra em ny beräkning
    Console.WriteLine("Vill du göra en ny beräkning? (j/n) ");
    string svar = Console.ReadLine()!.ToLower().Trim();
    if (svar == "n") //(svar != "j")
    {
        break;
    }
}