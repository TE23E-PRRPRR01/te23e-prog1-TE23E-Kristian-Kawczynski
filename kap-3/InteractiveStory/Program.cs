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

Console.WriteLine("Du vaknar i ett rum och ser ett svärd, vill du ta upp den? (y/n)");
string answer = Console.ReadLine();

if (answer == "y")
{
    Console.WriteLine("Du ställer dig upp och tar up svärdet! Vill di gå igenom dörren?");
    Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Du går igenom dörren och ramlar ner i ett hål");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("En drake bränner upp rummet");
        Cosnole.ReadLine();
    }

}
else
{
    Console.WriteLine("En drake brinner up hela rummet! Men du lyckas överleva, vill du ta upp svärdet?");
    Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Svärdet blev cursed och du blev possesed");
        Cosnole.ReadLine();
    }
    else
    {
        Console.WriteLine("Draken äter upp dig3");
        Console.ReadLine();
    }
    
}