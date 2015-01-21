using System;

//Create console application that prints the current date and time.


class TimeAndDateNow
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy."));
    }
}

