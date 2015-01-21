using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area.

class RadiusOfCircle
{
    static void Main()
    {
        Console.Write("Enter desired radius: ");
        string strRadius = Console.ReadLine();
        double radius;

        if (double.TryParse(strRadius, out radius))
        {
            radius = double.Parse(strRadius);
            double Pi = Math.PI;
            double area = (Pi * (radius * radius));
            double perimeter = (2 * Pi * radius);
            Console.WriteLine("The circle with radius {0}, has\nArea = {1:F4}\nPerimeter = {2:F4}", radius, area, perimeter);
        }
        else
        {
            Console.WriteLine("This: {0} is not a number!", strRadius);
        }
    }
}

