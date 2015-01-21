using System;

//Create, compile and run a "Hello C#" console application.

class HelloCSharp
{
    static void Main()
    {        
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Hello C#");
        Console.ResetColor();
    }
}

