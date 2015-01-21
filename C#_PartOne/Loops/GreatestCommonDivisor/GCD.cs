using System;
/* Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
 * Use the Euclidean algorithm (find it in Internet).
 */
class GCD
{
    static void Main()
    {
        int first;
        do
        {
            Console.Write("Please enter the first number: ");
            
        } while (!int.TryParse(Console.ReadLine(), out first));

        int second;
        do
        {
            Console.Write("Please enter the second number: ");
        } while (!int.TryParse(Console.ReadLine(), out second));

        while (first != 0 && second != 0)
        {
            if (first > second)
            {
                first -= second;
            }
            else
            {
                second -= first;
            }
            Console.WriteLine("The geratest common divisor is: " + Math.Max(first, second));
        }
    }
}

