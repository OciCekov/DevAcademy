using System;

//Write an expression that calculates rectangle’s area by given width and height.

class RectangleWidthHeight
{
    static void Main()
    {
        Console.Write("Please enter width, it is not requiered to be whole number: ");
        float widht = float.Parse(Console.ReadLine());
        Console.Write("Please enter height it is not requiered to be whole number: ");
        float height = float.Parse(Console.ReadLine());
        float area = widht * height;
        Console.Write("Area of the current rectangle is: {0}\n", area);
    }
}

