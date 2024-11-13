//Slumpa många tal och spar i en lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

// Globala variabler
//En lista för heltal
List<int> listaSlumptal = [];

//Be användaren att ange min & max slumptal
Console.Write("Ange minsta värde för slumptal: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Ange största värde för slumptal: ");
int max = int.Parse(Console.ReadLine()!);

//Be användaren att ange antal slumpade tal
Console.Write("Ange antal slumpade tal: ");
int antal = int.Parse(Console.ReadLine()!);

//loopa 5 ggr
for (int i = 0; i < antal; i++)
{
    //Sluma ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max + 1);

    //Läg till slumptalet i listan
    listaSlumptal.Add(slumptal);
    Console.WriteLine($"Slumpat tal {i + 1}: {slumptal}");
}
