//Fråga användaren om namn
using System.Formats.Asn1;

Console.Clear();
Console.WriteLine("Välkommen till min frågesport! ");
Console.WriteLine("Ange ditt namn: ");
string namn = Console.ReadLine()!;
int poäng = 0;
//Frågor

    string answer1 = "";
    string answer2 = "";
    string answer3 = "";
while (true)
{
    while (true)
    {
        Console.WriteLine("Vilken alfabet används för Japanska ord? ");
        Console.WriteLine("a) Katakana");
        Console.WriteLine("b) Kanji");
        Console.WriteLine("c) Hiragana");
        answer1 = Console.ReadLine()!;
        if (answer1 == "a" || answer1 == "b" || answer1 == "c")
        {
            break;
        }
    }
    if (answer1 == "c")
    {
        poäng++;
    }

    while (true)
{
    Console.WriteLine("Hur säger man Godmorgon i Japanska? ");
    Console.WriteLine("a) Arigatoo");
    Console.WriteLine("b) Nǐ hǎo");
    Console.WriteLine("c) Ohayo");
    if (answer2 == "a" || answer2 == "b" || answer2 == "c")
    {
        break;
    }
    if (answer2 == "c")
    {
        poäng++;
    }
}
    while (true)
{
    Console.WriteLine("Vilken stad finns i Japan? ");
    Console.WriteLine("a) Kyoto");
    Console.WriteLine("b) Phuket");
    Console.WriteLine("c) Hanoi");
    if (answer3 == "a" || answer3 == "b" || answer3 == "c")
    {
        break;
    }
    if (answer3 == "a")
    {
        poäng++;
    }
}

//Fråga om användaren vill spela igen
Console.WriteLine($"{namn} Vill du spela igen? (y/n)");
string igen = Console.ReadLine()!;
if (igen == "n")
{
    break;
}
}

//Slutet och Resultat
Console.WriteLine("Tack att du spelade mitt spel! ");
Console.WriteLine($"Ditt resultat är {poäng}, som är {3 - poäng} poäng från maxpoäng ");
