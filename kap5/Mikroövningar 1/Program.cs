//Lista program
List<string> listaNamn = ["Miruko", "Monika"];

string.Join(", ", listaNamn);

Console.WriteLine($"abc: {string.Join(", ", listaNamn)}");

// foreach (var namn in listaNamn)
// {
//     Console.Write($"{namn}, ");
// }

//finns i listan
// if (listaNamn.Contains(""))
// {
//     Console.WriteLine("Den finns");
// }
// else
// {
//     Console.WriteLine("Den finns inte");
// }

//ta bort 
//listaNamn.Remove("");

Console.Write("Ange ett nytt namn till listan: ");
listaNamn.Add(Console.ReadLine()!);

Console.WriteLine($"abc: {string.Join(", ", listaNamn)}");
