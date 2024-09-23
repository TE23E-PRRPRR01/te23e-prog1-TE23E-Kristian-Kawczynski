// Spelet gissa ett slumptal 1-100
Console.Clear();
Console.WriteLine("Spelet gissa ett slumptal 1-100");

//Be användaren agre slumptalet gränser med min och max
Console.WriteLine("Ange slumptalets min-värde");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ange slumptalets max-värde");
int max = int.Parse(Console.ReadLine()!);

// Slumpar ett tal 1-100
int slumptal = Random.Shared.Next(min, max + 1);

// Upprepning - loop
while (true)
{
    // ställ fråga till användaren
    Console.WriteLine($"Gissa ett tal ({min}-{max}): ");
    int gissning = int.Parse(Console.ReadLine()!);

    // Kontroll om gissning är rätt?
    if (gissning == slumptal)
    {
        Console.WriteLine("Rätt gissat!");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt!");
    }
    
    Console.Write("Vill du gissa en gång till (y/n): ");
    string svar = Console.ReadLine();
    if (svar == "n")
    {
        break;
    }
}
    //Slut på spelet
Console.WriteLine("Slut!, Tack för att du spelade mitt fina spel!");