using System;

/* Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
*/

class SumForS
{
    static void Main()
    {
        Console.Write("Enter value for N: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Enter value for X: ");
        double x = double.Parse(Console.ReadLine());
        double sum = 1.0;
        double factoriel = 1;
        for (double i = 1; i <= n; i++)
        {
            factoriel *= i;
            sum += factoriel / Math.Pow(x, i);
        }
        Console.WriteLine("Some magic was done, discovered sum is: " +sum);
    }
}

