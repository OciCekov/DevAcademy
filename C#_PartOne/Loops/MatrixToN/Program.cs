using System;

/* Write a program that reads from the console a positive integer number N (N < 20) and outputs square. */

namespace MatrixToN
{
    class Program
    {
        static void Main()
        {
            byte finalNumber;
            do
            {
                Console.Write("Please enter number N<20  ");
            } while (!byte.TryParse(Console.ReadLine(), out finalNumber));

            for (int i = 1; i <= finalNumber; i ++)
            {
                
                for (int number = i; number < (i + finalNumber); number++)
                {
                    Console.Write("{0}", number);
                }
                Console.WriteLine();
                
            }
            Console.WriteLine();
        }
    }
}
