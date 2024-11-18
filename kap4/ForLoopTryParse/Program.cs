//Skapa en enkel loop som loopar ditt namn 10 gånger
Console.Clear();
Console.WriteLine("Ett program som loopar ett namn");

// Variabel bas
int nummer = 1;

// Fråga användaren om namn
Console.Write("Ange ditt namn: ");
string namn = Console.ReadLine()!;

while (true)
{
    // Fråga hur många gånger användaren vill loopa
    Console.WriteLine("Hur många gånger vill du loopa");
    string antal = Console.ReadLine()!;
    int antalloop = 0;
    bool success = int.TryParse(antal, out antalloop);

    if (antalloop > 0 || antalloop < 11)
    {
        for (int i = 0; i < antalloop; i++)
        {
            Console.WriteLine($"{nummer++}. {namn}");
            break;
        }
    }
    else
    {
        Console.WriteLine("Du gav för många loops, Håll dig mellan 1 och 10");
        Console.Write("Vill du försöka igen? (j/n)");
        string svar = Console.ReadLine()!.ToUpper();

        if (svar == "n")
        {
            break;
        }
        else
        {
            
        }
        

    }
}



