// Register av spel karaktärer
Console.Clear();
Console.WriteLine("Register av spel karaktärer");


//Programloopen
while (true)
{


    //Visa ett meny
    Console.WriteLine("""
1. Registrera
2. Skriva ut 
3. Avsluta 

Ange ditt val: 
""");
    List<string> characters = [];
    string val = Console.ReadLine()!;

    if (val == "1")
    {
        while (true)
        {
            Console.Write("Ange en karakär: ");
            string character = Console.ReadLine()!;
            characters.Add(character);

            Console.WriteLine("""
            Är det alla?
            1. Nej, Fortsätt
            2. Ja, Bakåt
            """);
            string val2 = Console.ReadLine()!;
            if (val2 == "2")
            {
                break;
            }
        }
    }
    if (val == "2")
    {
        while (true)
        {
            foreach (var charr in characters)
            {
                Console.Write($"{charr}, ");
            }
            Console.WriteLine();
        }
    }
    if (val == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingen giltig val anget, Försök igen");
    }
}