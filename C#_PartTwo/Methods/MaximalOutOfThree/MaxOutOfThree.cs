using System;

/*Write a method GetMax() with two parameters that returns the bigger of two integers.  
 * Write a program that reads 3 integers from the console
 * and prints the biggest of them using the method GetMax().
 */

class MaxOutOfThree
{
    static int GetMax(int first, int second)
    {
        int bigger = int.MinValue;
        if (first > second)
        {
            bigger = first;
        }
        else
        {
            bigger = second;
        }

        return bigger;
    }

    static void Main()
    {
        Console.Write("Please input the first integer: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("And now the second: ");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("Bigger out of first two is: " + GetMax(first, second));

        Console.Write("Now it's finally time for the third: ");
        int third = int.Parse(Console.ReadLine());

        int solution = GetMax(GetMax(first, second), third);
        Console.Write("The biggest out of three is: " + solution);
        Console.WriteLine();
    }
}

