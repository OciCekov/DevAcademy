using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.
//
class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter side \"a\": ");
        string strA = Console.ReadLine();

        Console.Write("Enter side \"b\": ");
        string strB = Console.ReadLine();

        Console.Write("Enter height \"h\": ");
        string strH = Console.ReadLine();

        int a = int.Parse(strA);
        int b = int.Parse(strB);
        int h = int.Parse(strH);
        int half = ((a + b)*h);
        int all = half / 2;
        Console.WriteLine("Area of the trapezoid with your requierements is {0}", all);
    }
}

