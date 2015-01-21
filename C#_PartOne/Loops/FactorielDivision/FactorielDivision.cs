using System;

/* Write a program that calculates N!/K! for given N and K (1<K<N).
*/

class FactorielDivision
{
    static void Main()
    {
        Console.Write("Enter N = ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Enter K = ");
        double k = double.Parse(Console.ReadLine());
        double factorielN = 1;
        double factorielK = 1;

        if (1 < k && 1 < n && k < n)
        {

            for (double i = n; 1 < i; i--)
            {
                factorielN *= i;
            }


            for (double i = k; 1 < i; i--)
            {
                factorielK *= i;
            }
           
            Console.WriteLine(factorielN / factorielK);
        }

        else
        {
            Console.WriteLine("It should be 1<K<N, somwhere you made it wrong!");
        }
    }
}

