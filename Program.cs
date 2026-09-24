// https://git-scm.com/

Console.Write("enter your name here: ");
string name = Console.ReadLine() ?? throw new Exception("cannot be null");

string hw = $"Hello, {name}!";

Console.Write("how many times?: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{    
    foreach (var c in hw)
    {
        Console.ForegroundColor = (ConsoleColor)Random.Shared.Next(1, 16);
        Console.Write(c);
    }
    Console.Write('\n');
}

while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
