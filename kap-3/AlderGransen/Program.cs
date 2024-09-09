Console.Clear();
Console.WriteLine("Ange ditt ålder. ");

string gissningText = Console.ReadLine()!; //?= kanske existerar kanske inte - != bryr mig inte om det existerar ---Love

int gissning = int.Parse(gissningText);

// 18-får ta körkort för bil --- 21-Handla på systemet --- 16- ta mopedkörkort --13- får använda sociala medier

if (gissning > 19)
{
    Console.WriteLine("Du får göra allt lagligt, sociala medier, ta körkort och handla på systemt ");
}
else
{
    if (gissning > 17)
    {
        Console.WriteLine("Du kan ta körkort");
    }
    else
    {
        if (gissning > 15 && gissning < 18)
        {
            Console.WriteLine("Du får ta moped körkort");
        }
        else
        {
            if (gissning > 12 && gissning < 16)
            {
                Console.WriteLine("Du får använda sociala medier");
            }
            else
            {
                if (gissning < 13)
                {
                    Console.WriteLine("Du är för ung");
                }
            }
        }
    }
}