// https://git-scm.com/

Console.Write("enter your name here: ");
string name = Console.ReadLine() ?? throw new Exception("cannot be null");

string hw = $"Hello, {name}!";

foreach (var c in hw)
{
    Console.ForegroundColor = (ConsoleColor)Random.Shared.Next(1, 16);
    Console.Write(c);
}

while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;