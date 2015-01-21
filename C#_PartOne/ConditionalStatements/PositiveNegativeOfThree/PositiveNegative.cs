using System;

/* Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
*/


class PositiveNegative
{
    static void Main()
    {
        
        Console.Write("Enter the first number: ");
        double firstN;
        while (!double.TryParse(Console.ReadLine(), out firstN))
        {
            Console.Write("It can be negative or positive, but it has to be a number, you have another try: ");
        }
        
        Console.Write("Enter the second number: ");
        double secondN;
        while (!double.TryParse(Console.ReadLine(), out secondN))
        {
            Console.Write("A number please, next try: ");
        }
      
        Console.Write("Time for third number: ");
        double thirdN;
        int atempts = 1;
        while(!double.TryParse(Console.ReadLine(), out thirdN))
        {
            Console.WriteLine("You made it ok this far, don't ruin it: ");
            atempts++;

            if (atempts == 4)
            {
                Console.WriteLine("You broke it sorry, no more chances!");
                break;
            }
        }
       
        if (firstN > 0 && secondN > 0 && thirdN > 0)
        {
            Console.WriteLine("(+) \nThe product is positive");
        }

        else if (firstN > 0 && secondN < 0 && thirdN < 0)
        {
            Console.WriteLine("(+) \nThe product is positive.");
        }

        else if (firstN < 0 && secondN < 0 && thirdN > 0)
        {
            Console.WriteLine("(+) \nThe product is positive.");
        }

        else if (firstN < 0 &&secondN > 0 && thirdN < 0)
        {
            Console.WriteLine("(+) \nThe product is positive.");
        }

        else if (firstN > 0 && secondN > 0 && thirdN < 0)
        {
            Console.WriteLine("(-) \nThe product is negative.");
        }

        else if (firstN < 0 && secondN < 0 && thirdN < 0)
        {
            Console.WriteLine("(-) \nThe product is negative.");
        }

        else if (firstN < 0 && secondN > 0 && thirdN >0)
        {
            Console.WriteLine("(-) \nThe product is negative.");
        }
       
    }
}

