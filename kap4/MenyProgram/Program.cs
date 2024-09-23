// Litet program med meny
Console.Clear();
Console.WriteLine("Litet program med meny");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Variabel för valet
string val = "";

// Programloop som snurrar till användaren säfer avsluta
while (true)
{
    // Visa en Meny och läser in användarens val
    Console.WriteLine("""
    1. Omvandla en text till versaler
    2. Omvandla en text till gemener

    3. Avsluta

    Välj ett av alternativen ovan:
    """);
    val = Console.ReadLine()!;

    //Hantera användarens val
    if (val == "1")
    {
        Console.Write("Skriv in en text: ");
        string texten = Console.ReadLine()!.ToUpper();
        Console.WriteLine($"Texten i versaler blir :{texten}");
    }
    else if (val == "2")
    {
        Console.Write("Skriv in en text: ");
        string texten = Console.ReadLine()!.ToLower();
        Console.WriteLine($"Texten i versaler blir :{texten}");
        
    }
    else if (val == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Du valde inget gilrigt allternativ, försök igen!");
    }
}