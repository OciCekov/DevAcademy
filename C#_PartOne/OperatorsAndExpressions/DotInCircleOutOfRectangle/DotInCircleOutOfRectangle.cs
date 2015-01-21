using System;

/*Write an expression that checks for given point (x, y) if it is within the circle
 * K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */ 

class DotInCircleOutOfRectangle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        double radius = 3;
        double centeX = 1;
        double centerY = 1;
        bool circle = ((centeX - x) * (centeX - x) +(centerY-y)*(centerY-y))<= radius*radius;
        bool rectangle = ((x < 7 && x > 1 )&&( y < -1 && y < -3));
        if (circle && rectangle)
        {
            Console.WriteLine("The point is in the circle and in the rectanlge");
        }
        else if (circle == true && rectangle == false)
        {
            Console.WriteLine("The point is in the circle and out of rectangle");
        }
        else if (circle == false && rectangle ==true)
        {
            Console.WriteLine("The point is out of the circle and in the rectangle");
        }
        else if (!(circle && rectangle ))
        {
            Console.WriteLine("The point is out of this planet! "); 
        }
    }
}

