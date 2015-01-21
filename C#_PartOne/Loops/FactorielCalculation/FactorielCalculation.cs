using System;

/* Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
*/

class FactorielCalculation
{
    static void Main()
    {
        Console.Write("Enter N = ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Enter K = ");
        double k = double.Parse(Console.ReadLine());
        double factorielN = 1;
        double factorielK = 1;
        double divisor = (k - n);
        double factorielDivisor = 1;

        if (1 < k && 1 < n && n < k)
        {

            for (double i = n; 1 < i; i--)
            {
                factorielN *= i;
            }


            for (double i = k; 1 < i; i--)
            {
                factorielK *= i;
            }

            for (double i = divisor; 1 < i; i--)
            {
                factorielDivisor *= i;
            }

            Console.WriteLine((factorielN * factorielK)/factorielDivisor);
        }
        else
        {
            Console.WriteLine("You made a mistake in the input, it should be: 1<N<K");
        }
    }
}

