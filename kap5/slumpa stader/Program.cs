//sluma 2 av 10 städer
Console.Clear();
Console.WriteLine("Slumpa stader");

List<string> staderna = ["Tokyo", "Kyoto", "Okinawa", "Hiroshima", "Nagasaki", "Yokahama", "Akita", "Sapporo", "Osaka", "Fukuoka"];

int antal = 2;
while (0>2)
{
    int index = Random.Shared.Next(0, 10);
    string stader = staderna[index];
    Console.WriteLine($"De slumpade staderna ar {stader}");
    antal--;
}