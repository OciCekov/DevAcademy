using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that finds in given array of integers a sequence of given sum S (if present).
 * Example:	{4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
 */

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter how long should the array be: ");
        int arrlenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrlenght];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter a number: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Now what sum should we seek for: ");
        int sum = int.Parse(Console.ReadLine());

        int theBeggining = 0;
        int theEnd = 0;
        int now = 0;
        for (int i = 0; i < array.Length; i++)
        {
            theBeggining = i;
            for (int j = i; j < array.Length - 1; j++)
            {
                theEnd = j;
                now += array[j];
                if (now > sum)
                {
                    now = 0;
                    break;
                }
                else if (now < sum) 
                {
                    continue;
                }
                else
                {
                    for (int k = theBeggining; i <= theEnd; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
        }
        
    }
}

