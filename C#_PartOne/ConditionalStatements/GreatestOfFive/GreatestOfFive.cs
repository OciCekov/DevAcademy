using System;
/* Write a program that finds the greatest of given 5 variables.
*/

class GreatestOfFive
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int final;
        
        while (!int.TryParse(Console.ReadLine(), out final)) 
        {
            Console.Write("No magic is allowed, we need number: ");
        }

        Console.Write("Enter second number: ");
        int second;

        while (!int.TryParse(Console.ReadLine(), out second))
        {
            Console.Write("Opps, it seems wrong to do that, try with number: ");
        }

        Console.Write("Enter third number: ");
        int third;

        while (!int.TryParse(Console.ReadLine(), out third))
        {
            Console.Write("Why you have to do this to me, number is what I need: ");
        }

        Console.Write("Enter fourth number: ");
        int fourth;

        while (!int.TryParse(Console.ReadLine(),out fourth))
        {
            Console.Write("So..... NO! A number please: ");
        }

        Console.Write("Enter fifth number: ");
        int fifth;
        while (!int.TryParse(Console.ReadLine(), out fifth))
        {
            Console.WriteLine("You made it good this far but now... try again: ");
        }

        if (final < second)
        {
            final = second;
        }

        if (final < third)
        {
            final = third;
        }

        if (final < fourth)
        {
            final = fourth;
        }

        if (final < fifth)
        {
            final = fifth;
        }

        Console.WriteLine("The greatest of this numbers is: {0}",  final);
    }
}

