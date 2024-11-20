Console.Clear();
//Console.WriteLine("Program som skriver ut heltail");

//Startvärde
//Console.Write("Ange ett startvärde: ");
//int startvärde = int.Parse(Console.ReadLine()!);

//Slutvärde
//Console.Write("Ange ett slutvärde: ");
//int slutvärde = int.Parse(Console.ReadLine()!);

//int summa = 0;
//Skriv ut
//for (int i = startvärde; i < slutvärde+1; i++)
{
   // Console.WriteLine(i);
    //summa += i;
}
    //Console.WriteLine($"Summan av alla heltalen är {summa}");


//Startvärde
Console.Write("Ange ett startvärde: ");
int startvärde = int.Parse(Console.ReadLine()!);

//Slutvärde
Console.Write("Ange ett slutvärde: ");
int slutvärde = int.Parse(Console.ReadLine()!);

Console.Write("Jämna tal: ");
for (int i = 1; i < 21; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i},");
    }
}
Console.WriteLine();

Console.Write("Udda tal: ");
for (int i = 1; i < 21; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{i}, ");
    }
}