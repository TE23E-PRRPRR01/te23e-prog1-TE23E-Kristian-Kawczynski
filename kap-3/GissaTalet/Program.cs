Console.Clear();
Console.WriteLine("Ett litet spel - gissa ett hemligt tal");

//slumpa ett tal
//int slumptalet = Random.Shared.Next(1, 101); // mellan 1-100
//Console.WriteLine($"Slumptalet är {slumptalet}"); // ("Slumptalet är " +slumptalet); (samma sak om $)
// .

Console.WriteLine("Gissa ett hemligt tall 1-100: ");
//Läs in texten, ex. "100"
string gissningText = Console.ReadLine();
//Konvertera texten till ett heltal, blir 100
int gissning = int.Parse(gissningText);

if (gissning == 45)
{
    Console.WriteLine("Bra, du har gissat rätt");
}
else
{
    if (gissning < 45)
    {
        Console.WriteLine("fel, svaret är större");
    }
    else
    {
        Console.WriteLine("fel, svaret är mindre");
    }
}
