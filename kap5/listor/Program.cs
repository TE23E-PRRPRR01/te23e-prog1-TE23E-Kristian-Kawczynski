// Använda listor för att skapa/hantera samlingar
Console.Clear();

//Lista på trevliga frukter tex "äpple, apelsin, päron
List<string> frukter = ["äpple", "apelsin", "päron"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

//Ändra i listan
frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

//Gå igenom listan =  loopa igenom listan = från första till sista 
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

//skapa en lista på valfri sak(4 st)
//skriv ut varje sak på samma rad
Console.Clear();

List<string> gems = ["Primogems", "Stellarjades", "Polychromes", "Astrites"];

foreach (var gem in gems)
{
    Console.Write($"{gem} ");
}

for (int i = 0; i < gems.Count; i++)
{
    Console.WriteLine($"{gems[i]}");
}

//Skapa ett register
//En tom lista
List<string> waifus = [];

// while loop
while (true)
{
    Console.Write("Ange en waifu: ");
    string waifu = Console.ReadLine()!;
    waifus.Add(waifu);

    //Skriv ut hela listan på en rad
    foreach (var waifun in waifus)
    {
        Console.Write($"{waifun}, ");
    }
    Console.WriteLine();
}