using System;

//Create a console application that calculates and prints the square of the number 12345.

class SquareOfNumber
{
    static void Main()
    {
        int? a = 12345;
        Console.WriteLine(a.Value*a); 
    }
}

