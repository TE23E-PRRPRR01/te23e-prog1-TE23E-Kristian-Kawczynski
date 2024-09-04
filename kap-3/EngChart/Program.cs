Console.Clear();
Console.WriteLine("Välkommen till ingenjörs flödeschema");

Console.WriteLine(
$"""
                                       $"   *.      
              d$$$$$$$P"                  $    J
                  ^$.                     4r  "
                  d"b                    .db
                 P   $                  e" $
        ..ec.. ."     *.              zP   $.zec..
    .^        3*b.     *.           .P" .@"4F      "4
  ."         d"  ^b.    *c        .$"  d"   $         %
 /          P      $.    "c      d"   @     3r         3
4        .eE........$r===e$$$$eeP    J       *..        b
$       $$$$$       $   4$$$$$$$     F       d$$$.      4
$       $$$$$       $   4$$$$$$$     L       *$$$"      4
4         "      ""3P ===$$$$$$"     3                  P
 *                 $       "'"        b                J
  ".             .P                    %.             @
    %.         z*"                      ^%.        .r"
       "*==*""                             ^"*==*""  
"""
);


Console.WriteLine("Does it move? (y/n) ");
string answer = Console.ReadLine();

if (answer == "y")
{
    Console.WriteLine("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("No problem!");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Plz use Duct tape!");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Plz use WD-40");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("No problem!");
        Console.ReadLine();
    }
}