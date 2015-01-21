using System;

/* Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
 */

class AccurateDivision
{
    static void Main()
    {
        double result = 1;
        double oldResult = 0;
        
        for (int i = 2; 0.001 <= Math.Abs(result - oldResult); i++)
        {
            oldResult = result;
            if (i % 2 == 0)
            {
                result += 1.0 / i;
            }
            else
            {
                result -= 1.0 / i;
            }

        }
        Console.WriteLine("{0:F3}", result);
    }
}

