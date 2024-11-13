// Ett dungeon spel med massa rum, saker, fiender, skatter...
Console.Clear();
Console.WriteLine("Ett Dungeon spel");

// Program variabler (state variables)
string rum = "hallen"
List<string> inventory = [];
int liv = 3;

//spel loop
while (true)
{
    // är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.Write("Vad vill du göra");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar runt i rummet och ser några gammla tavlor");
        }
        else if(val == "2")
        {
            rum = "rum 1";
            Console.WriteLine(" du går till nästa rum ");
        }
    }
    else if (rum == "rum 1")
    {
        Console.WriteLine("Du är i rum 1");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till hallen");
        Console.WriteLine("3. Gå till nästa rum]");
        Console.Write("Vad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en nyckel på golvet");
            Console.Write("Vill du plockaup nyckeln (j/n)");
            val = Console.ReadLine();
            if (val == "j")
            {
                inventory.Add("nyckel")
                Console.WriteLine("Du plockade up nyckeln");
            }
            else
            {
                Console.WriteLine("Du lämnade nyckeln på golvet!");
            }
        }
        else if(val == "2")
        {
            rum = "rum 1";
            Console.WriteLine(" du går till nästa rum ");
        }
    }
    else if (rum == "rum 2")
    {
        Console.WriteLine("Du är i rum 2");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till rum 2");
        Console.WriteLine("3. Gå till nästa rum");
        Console.Write("Vad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en en kista i hörnet");
            Console.Write("Vill du använda nyckeln (j/n)");
            val = Console.ReadLine();
            if (val == "j")
            {
                Console.WriteLine("Du öppnade kistan och ser ett svärd");
                Console.Write("Vill du plocka svärdet (j/n)");
                string val = Console.ReadLine().ToLower();
                if (!inventory.Add("svärd") && == "j")
                {
                    inventory.Add("svärd")
                    Console.WriteLine("Du plockade upp svärdet");
                }
            }
            else
            {
                Console.WriteLine("Du lämnade kistan");
            }
        }
        else if(val == "2")
        {
            rum = "rum 1";
            Console.WriteLine(" du går till nästa rum ");
        }
    }
    // Slumpa en händelse
int händelse = Random.Shared.Next(1,5);
if (händelse == 1)
{
    Console.WriteLine("Ett spöke dyker upp");
    
}
else if (händelse == 2)
{
    
}
else if (händelse == 3)
{
  
}
else if (händelse == 4)
{

}
else if (händelse == 5)
{

}
else if (händelse == 6)
{

}
}


//Är liven slut?
// if (liv <= 0)
//{
//    break;
//}