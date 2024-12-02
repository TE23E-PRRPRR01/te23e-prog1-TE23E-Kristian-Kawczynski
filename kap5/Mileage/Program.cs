List<string> listaMat = ["Curry", "Pierogi", "Rice"];
Console.WriteLine($"Matlista:");
foreach (var mat in listaMat)
{
    Console.Write($" {mat}, ");
}

Console.WriteLine();

List<int> listaÅrtal = [996, 1918, 966, 1945, 1992];
Console.Write("Årtal: ");
foreach (var år in listaÅrtal)
{
    Console.Write($"{år}, ");
}

Console.WriteLine();

List<string> listaNamn = [];

Console.WriteLine("Lägg till namn en namnlista");
while (true)
{
    Console.Write("Ange ett namn att lägga till: ");
    listaNamn.Add(Console.ReadLine()!);
}