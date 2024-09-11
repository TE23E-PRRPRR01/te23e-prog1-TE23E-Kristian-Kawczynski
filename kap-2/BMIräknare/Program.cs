using System.ComponentModel;

Console.Clear();
Console.WriteLine("Program för att räkna utt ditt BMI");

Console.WriteLine("Ange din vikt: ");
double vikt = double.Parse(Console.ReadLine()!);

Console.WriteLine("Ange din längd i meter: ");
double längd = double.Parse(Console.ReadLine()!);

double BMI = vikt / (längd * längd);

Console.WriteLine($"Din BMI är {BMI}");