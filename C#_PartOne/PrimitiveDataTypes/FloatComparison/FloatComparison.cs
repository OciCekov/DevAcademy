using System;

/*Write a program that safely compares floating-point numbers with precision of 0.000001.
 *Examples:(5.3 ; 6.01) = false;  (5.00000001 ; 5.00000003) = true
 */

class FloatComparison
{
    static void Main()
    {
        Console.Write("Please enter first number:");
        decimal first = decimal.Parse(Console.ReadLine());
        Console.Write("And now the second number:");
        decimal second = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Your numbers are: {0} and {1}", first, second);
        bool result = (Math.Abs(first - second) < 0.000001m);
        if (result) 
        {
            Console.WriteLine("The numbers are equal \n");
        }
        else
        {
            Console.WriteLine("The numbers are not equal for given criteria \n"); 
        }

    }
}

