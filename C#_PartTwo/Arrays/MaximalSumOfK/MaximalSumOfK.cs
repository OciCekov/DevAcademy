using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads two integer numbers N and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
 * 
 * Disclaimer: I'm not 100% sure that I made this corectly but this was the way that I understood it. 
 */

class MaximalSumOfK
{
    static void Main()
    {
        Console.Write("Please enter how big should be the array: ");
        int N = int.Parse(Console.ReadLine());
        
        Console.Write("Now, sum of how many members should we seek? ");
        int K = int.Parse(Console.ReadLine());
        
        int[] array = new int[N];
        
        for (int i = 0; i < array.Length; i++) 
        {
            Console.Write("Enter the numbers for the array: ");
            int arrayFill = int.Parse(Console.ReadLine());
            array[i] = arrayFill;
        }

        Array.Sort(array);
        int sum = 0;
        
        for (int i = array.Length - 1; i > K; i--)
        {
            sum += array[i];    
        }
        Console.WriteLine(sum);
        
      

    }
}

