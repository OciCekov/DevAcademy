using System;
/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them
 * such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
 */

class BetweenTwoNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        
        int devisibles = 0;
        
        for (int i = firstNum; i <= secondNum; i++)
        {        
            if (i %5 ==0)
            {
                devisibles++;
            }
        }
        Console.WriteLine("The numbers are: {0}",devisibles);
    }
}
