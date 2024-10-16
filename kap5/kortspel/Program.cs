//Hur man skapar och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpa kort i ett kortlek!");


//Skapa en lista kort
//lista på tal
//List<int> årtal =[1939, 1969, 1989];                                                                                                                                                           ♠   ♥   ♦   ♣
//List<string> kortlek = ["🏛️", "", "", "", "", "", "", ""] ctrl, shift, p  emoji insert
//List<string> kortlek = ["Ess", "Tvåa", "Trea", "Fyra", "Femma", "Sexa", "Sjua", "Åtta", "Nia", "Tia", "J", "Q", "K"];
List<string> kortlek = ["♠A", "♥A", "♦A", "♣A", "♠2", "♥2", "♦2", "♣2", "♠3", "♥3", "♦3", "♣3", "♠4", "♥4", "♦4", "♣4", "♠5", "♥5", "♦5", "♣5", "♠6", "♥6", "♦6", "♣6", "♠7", "♥7", "♦7", "♣7", "♠8", "♥8", "♦8", "♣8", "♠9", "♥9", "♦9", "♣9", "♠10", "♥10", "♦10", "♣10", "♠J", "♥J", "♦J", "♣J", "♠Q", "♥Q", "♦Q", "♣Q",  "♠K", "♥K", "♦K", "♣K",];

int antal = 5;
while (antal > 0)
{
    //slumpa index 0-12
    int index = Random.Shared.Next(0, kortlek.Count);
    //Console.WriteLine($"Det slumpande index = {index}");

    //Plocka ut det sjunde kortet, index = 6
    string kort = kortlek[index];

    //Ta bort kortet ur kortleken
    kortlek.RemoveAt(index);

    //Skriv ut /:e kortet
    Console.WriteLine($"Det slumpade kortet är {kort}");

    //Räkna ned
    antal--;
}