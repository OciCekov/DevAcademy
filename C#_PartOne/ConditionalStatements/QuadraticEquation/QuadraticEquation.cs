using System;
/*Write a program that enters the coefficients a, b and c of a quadratic equation

 */

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter number for \"a\": ");
        double numberA;

        while (!double.TryParse(Console.ReadLine(), out numberA))
        {
            Console.Write("Number, I need a nuber, please try again: ");
        }
        
        Console.Write("Enter number for \"b\": ");
        double numberB;

        while (!double.TryParse(Console.ReadLine(), out numberB))
        {
            Console.Write("Well... it has to be a valid number, try again: ");
        }
       
        Console.Write("Enter number for \"c\": ");
        double numberC;

        while (!double.TryParse(Console.ReadLine(), out numberC))
        {
            Console.Write("Well \"a\" is a number, \"b\" is a number, so \"c\" has to be? Yep, a number! \nTry again: ");
        }

        double discriminant = (numberB * numberB) - 4 * numberA * numberC;
        double firstRoot;
        double secondRoot;

        bool positive = discriminant > 0;
        bool negative = discriminant < 0;
        bool equalZero = discriminant == 0;

        if (positive)
        {
            firstRoot = (-numberB + Math.Sqrt(discriminant)) / (2 * numberA);
            secondRoot = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA);
            Console.Write("Discriminant is positive number: {0}, you have two real roots:\nx1= {1}; \nx2= {2}; \n", discriminant, firstRoot, secondRoot);
        }

        else if (equalZero)
        {
            firstRoot = -numberB / (2 * numberA);
            Console.Write("Discriminant is: {0}, you have one real root:\nx1= {1}; \n", discriminant, firstRoot);
        }

        else if (negative)
        {
            Console.WriteLine("Discriminant is negative number: {0}, you don't have any real roots.\n", discriminant);
        }
    }
}

