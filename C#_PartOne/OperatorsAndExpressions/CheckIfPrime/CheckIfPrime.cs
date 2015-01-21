using System;

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

class CheckIfPrime
{
    static void Main()
    {
        Console.Write("Enter desired number: ");
        int input = int.Parse(Console.ReadLine());
        if (!(input % 2 ==0 || input % 3 ==0 || input % 5 == 0 || input % 7 == 0))
        {
            Console.WriteLine("Your number is prime");
        }
        else
        {
            Console.WriteLine("Your number is not prime");
        }   
    }
}

