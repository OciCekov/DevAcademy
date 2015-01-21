using System;

/*Write a program to print the first 100 members of the sequence of Fibonacci:
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 */

class HundredFibonacciMembers
{
    static void Main()
    {
        decimal first = 0;
        decimal second = 1;
        decimal start;
        
        Console.WriteLine("{0}\n{1}", first, second);
        
        for (int i = 0; i < 98; i++)
        {
            start = first;
            first = second;
            second = first + start;
            Console.WriteLine(second);
        }
    }
}

