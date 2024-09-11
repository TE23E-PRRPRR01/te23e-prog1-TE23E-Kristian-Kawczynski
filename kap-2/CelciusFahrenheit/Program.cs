//omvandla celcius till fahrenheit
Console.Clear();
Console.WriteLine("Program för att konvertera temperaturen i Celsius till Fahrenheit");

//L'st Temp i Celsius
Console.WriteLine("Ange temperatur i Celsius: ");
int tempCelsius = int.Parse(Console.ReadLine()!);

//Konvertera till fahrenheit
int tempFahrenheit = tempCelsius * 9/5 + 32;

//Skriv ut resultat
Console.WriteLine($"{tempCelsius} Celsius är {tempFahrenheit} Fahrenheit");