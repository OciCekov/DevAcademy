using System;

//Write a program to print the numbers 1, 101, 1001.

class PrintTheNumbers
{
    static void Main()
    {
        int? a = 1;
        int? b = 101;
        int? c = 1001;
        Console.WriteLine(a.Value);
        Console.WriteLine(b.Value);
        Console.WriteLine(c.Value);
    }
}

