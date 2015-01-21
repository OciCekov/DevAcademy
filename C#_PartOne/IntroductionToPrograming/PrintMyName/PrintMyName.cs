using System;

//Modify the application to print your name.

class PrintMyName
{
    static void Main()
    {
        Console.Title = "My Name is Down there";
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine("Name");
        Console.ResetColor();
    }
}

