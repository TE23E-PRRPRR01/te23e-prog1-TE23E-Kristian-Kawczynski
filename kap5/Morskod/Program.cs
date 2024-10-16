//En liten morsekod app
Console.Clear();
Console.WriteLine("En liten morskod app");

//skapa två listor
List<string> alfabet = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " ", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"];
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/", "-----",".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----."];

//Läs in en text
Console.WriteLine("Ange ett meddelande: ");
string meddelande = Console.ReadLine()!;   //ToUpper

//Gå igenom meddelandet bokstav för bokstav (loop)
foreach (char bokstav in meddelande)
{
    //Uppslag i alfabetet efter index
    int index = alfabet.IndexOf(bokstav.ToString());

    //HIttar morsetecken A-Ö?
    if (index >= 0)
    {
        //Console.WriteLine($"{bokstav} finns på index {index}");

        //plocka ut morsetecknet för indexet
        string morsetecknet = morsekod[index];
        //Console.WriteLine($"{bokstav} är {morsetecknet}");
        Console.Write($"{morsetecknet} ");

        //Spela upp morse som ljud-beep
        //Tex D = -..
        //Dvs loopa igenom morsetecknet
        foreach (char signal in morsetecknet)
        {
            if (signal == '.')
            {
                //1000Hz, 200ms
                Console.Beep(1000, 200);
            }
            else // '-'
            {
                Console.Beep(1000, 600);
            }
        }
    }
    else
    {
        Console.WriteLine("?");
    }
}


