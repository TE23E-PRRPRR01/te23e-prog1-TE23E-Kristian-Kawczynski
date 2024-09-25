//Spelet BlackJack, även kallat 21:an
Console.Clear();
Console.WriteLine("BlackJack");

//Korten värde är
//2-10 = 2-10
//Knäckt Dam Kung = 10 || ESS = 1 eller 11

//Variabler
int summaSpelare = 0;
int summaDator = 0;
int kort = 0;

//Dela ut 2 kort till spelaren
kort = Random.Shared.Next(1, 11); // @todo J, Q, K, 
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); // @todo J, Q, K, 
summaSpelare += kort;
//Dela ut 2 kort till datorn
kort = Random.Shared.Next(1, 11); // @todo J, Q, K, 
summaDator += kort;
kort = Random.Shared.Next(1, 11); // @todo J, Q, K, 
summaDator += kort;

//Flera gånger (loop)
while (true)
{
    //Skriv ut summorna
    Console.WriteLine($"Du har {summaSpelare}");
    Console.WriteLine($"Datorn har {summaDator}");

    // Stanna eller dra ett kort?
    Console.Write("Vill du ta ett nytt kort? (j/n)");
    string svar = Console.ReadLine()!.ToLower();
    if (svar == "n")
    {
        //@todo datorn får ta extra kort <= 17
        while (summaDator < 17)
        {
        kort = Random.Shared.Next(1,11);
        summaDator += kort;
        }
        
        //Vem har vunnit(mest poäng)?
        //Den som är närmast 21 har vunnit
        if (summaSpelare > summaDator && summaSpelare <21)
        {
            Console.WriteLine("Du har vunnit");
        }
        else
        {
            Console.WriteLine("Datorn har vunnit");
        }
        break;
    }

    //Ta ett extra kort
    kort = Random.Shared.Next(1, 11); // @todo J, Q, K, 
    summaSpelare += kort;
    //Skriv ut kortet
    Console.WriteLine($"Du fick {kort}");
    

    //Datorn får också ett nytt kort
    kort = Random.Shared.Next(1, 11); // @todo J, Q, K, 
    summaDator += kort;
    //Skriv ut kortet
    Console.WriteLine($"Datorn fick {kort}");

    //Vem har vunnit
    //Har datorn fått 21 o vunnit
    if (summaDator == 21)
    {
        Console.WriteLine("Datorn har vunnit");
        break;
    }
    //Har spelaren fått 21 har hen vunnit
    if (summaSpelare == 21)
    {
        Console.WriteLine("Du har vunnit");
        break;
    }

    //Är spelaren shock
    if (summaSpelare > 21)
    {
        Console.WriteLine("Du har Förlorat");
        break;
    }
    //Är datorn shock
    if (summaDator > 21)
    {
        Console.WriteLine("Du har Vunnit");
        break;
    }

}