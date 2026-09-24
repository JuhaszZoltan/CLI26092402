//https://git-scm.com/

string hw = "Hello, World!";

foreach (var c in hw)
{
    Console.ForegroundColor = (ConsoleColor)Random.Shared.Next(1, 16);
    Console.Write(c);
}

while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;