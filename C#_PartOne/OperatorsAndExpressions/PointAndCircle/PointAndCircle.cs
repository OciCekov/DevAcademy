using System;

// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

class PointAndCircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        string stringX = Console.ReadLine();
        Console.Write("Enter y: ");
        string stringY = Console.ReadLine();
        double x = double.Parse(stringX);
        double y = double.Parse(stringY);
        double r = 5;
        double input = ((x * x) + (y * y));

        if (input <= r*r)
        {
            Console.WriteLine("Point is within the circle");
        }
        else
        {
            Console.WriteLine("Point is not within the circle");
        }
    }
}

