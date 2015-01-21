using System;
using System.Numerics;
/* Write a program that reads a number N and calculates the sum
 * of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
 * Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
 */

class SumWithFibonacci
{
    static void Main()
    {
        Console.Write("Please enter where the sum should end: ");
        int end = int.Parse(Console.ReadLine());
        
        BigInteger result = 0;
        BigInteger firstMember = 0;
        BigInteger secondMember = 1;
        
        for (int i = 0; i < end; i++)
			{
                result += firstMember;
                BigInteger all = firstMember + secondMember;
                firstMember = secondMember;
                secondMember = all;
			}
        Console.WriteLine("Sum of the members to {0} is: {1}", end, result);
    }
}

