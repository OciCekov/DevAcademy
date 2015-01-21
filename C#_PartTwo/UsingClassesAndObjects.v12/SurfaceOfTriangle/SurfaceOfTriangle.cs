using System;

/* Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
 * 
 * Yes there was simpler way but..... just for an excersise 
 */

class SurfaceOfTriangle
{
    static double SurfaceSideAndAltitude(double side = 3, double altitude = 4)
    {
        double surface = (side * altitude) / 2; ;
        return surface;
    }
    static double SurfaceTwoSidesAndAngle(double firstSide = 3, double secondSide = 4 , double angle = 90)
    {

        double surface = (firstSide * secondSide * Math.Sin(Math.PI * angle / 180)) / 2;
        return surface;
    }
    static double SurfaceThreeSides(double firstSide = 3, double secondSide = 4, double thirdSide = 5)
    {

        double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;

        double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));

        return surface;
    }
    static double Options(int input)
    {
        if (input == 1)
        {
            Console.Write("Now enter side = ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Now enter altitude = ");
            double altitude = double.Parse(Console.ReadLine());
            return SurfaceSideAndAltitude(side, altitude);
        }
        else if (input == 2)
        {
            Console.Write("Now enter first side = ");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Now enter second side = ");
            double secondSide = double.Parse(Console.ReadLine());
            Console.Write("Now enter the angle = ");
            double angle = double.Parse(Console.ReadLine());
            return SurfaceTwoSidesAndAngle(firstSide, secondSide, angle);
        }
        else if (input == 3)
        {
            Console.Write("Now enter first side = ");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Now enter second side = ");
            double secondSide = double.Parse(Console.ReadLine());
            Console.Write("Now enter third side = ");
            double thirdSide = double.Parse(Console.ReadLine());
            return SurfaceThreeSides(firstSide, secondSide, thirdSide);
        }
        else
        {
            Console.WriteLine("So you choose to do it with optional parameters.");
            Console.Write("You still have to choose which of the above methods should be used: ");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1) 
            {
                return SurfaceSideAndAltitude();
            }
            else if (userChoice == 2)
            {
                return SurfaceTwoSidesAndAngle();
            }
            else  if (userChoice == 3)
            {
                return SurfaceThreeSides();
            }
           else
           {
               return 0;
           }            
        }
    }
    static void Main()
    {
        Console.WriteLine("Here are your options");
        Console.WriteLine("1 = By side and altitude to it");
        Console.WriteLine("2 = By two sides and angle between them.");
        Console.WriteLine("3 = By threesides");
        Console.WriteLine("4 = Here you leave me to enter the dimensions");
        Console.Write("Your choice: ");
        string userInputStr = Console.ReadLine();
        int userInput;
        while (!int.TryParse(userInputStr, out userInput))
        {
            Console.Write("A number Please! ");
            userInputStr = Console.ReadLine();
        }
        if (userInput > 4 || userInput < 1) 
        {
            Console.WriteLine("Sorry, this wasn't the deal! ");
            return;
        }
        double result = Options(userInput);
        Console.WriteLine("The surface of triangle is =  {0:0.00}cm", result);
    }
}

