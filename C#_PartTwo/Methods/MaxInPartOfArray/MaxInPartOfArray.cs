using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a method that return the maximal element in a portion of array of integers starting at given index. 
 * Using it write another method that sorts an array in ascending / descending order.
*/


class MaxInPartOfArray
{
    static int[] InputedArray()
    {
        Console.Write("Enter how big should this array be: ");
        int lenght = int.Parse(Console.ReadLine());

        int[] array = new int[lenght];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Now enter array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }

    static int FindingMaximal(int whichPosition, int[] array)
    {        
        int max = 0;
        for (int i = whichPosition; i < array.Length; i++)
        {
            if (array[i]> max)
            {
                max = array[i];
            }
        }

        return max;
    }

    static int[] SortDescending(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        return array;
    }

    static int[] Ascending(int[] array)
    {
        Array.Sort(array);
        return array;
    }
    static void Main()
    {       
        int[] array= InputedArray();

        Console.Write("Enter from whitch element should we find biggest: ");
        int whichPosition = int.Parse(Console.ReadLine());

        int maxInput = FindingMaximal(whichPosition, array);
        Console.WriteLine("Maximal number from {0}, to {1} is {2}", whichPosition, array.Length, maxInput);
        Console.Write("Array in ascending order: ");
        PrintArray(Ascending(array));
        Console.Write("Array in descending order: ");
        PrintArray(SortDescending(array));
    }
}

