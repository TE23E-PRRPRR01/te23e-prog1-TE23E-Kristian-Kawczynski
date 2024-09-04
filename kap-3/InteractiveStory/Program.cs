Console.Clear();
Console.WriteLine("Välkommen till" );

Console.WriteLine(
$"""
                        ____________          ____     ____________    
                        \           \     ____\_  \__  \           \   
                         \           \   /     /     \  \           \  
                          |    /\     | /     /\      |  |    /\     | 
                          |   |  |    ||     |  |     |  |   |  |    | 
                          |    \/     ||     |  |     |  |    \/     | 
                          /           /||     | /     /| /           /| 
                         /___________/ ||\     \_____/ |/___________/ | 
                         |           | / | \_____\   | /|           | /  
                         |___________|/   \ |    |___|/ |___________|/   
                                           \|____| 
"""                    
);

Console.WriteLine("Dungeon of Doom!!!");

Console.WriteLine("Du vaknar i ett rum där en fackla lyser upp den, vill du ta upp facklan (y/n)");
string answer = Console.ReadLine();

if (answer == "y")
{
    Console.WriteLine("Du ställer dig upp och tar up facklan!");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Facklan sloknar och du fastnar i rummet i mörkret");
    Console.ReadLine();
}