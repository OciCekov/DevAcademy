using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch()
 * finds the largest number in the array which is ≤ K. 
*/

class LargestNumber
{
    static void Main()
    {
        Console.Write("Enter how big this array should be: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrLenght];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter, array[{0}]", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Now enter what number should we find: ");
        int searched = int.Parse(Console.ReadLine());
        Array.Sort(array);
        int found = Array.BinarySearch(array, searched);

        if (found == -1)
        {
            Console.WriteLine("Sorry, there is no such number");
        }
        else if (found >= 0)
        {
            Console.WriteLine("The number is on position, {0}", array[found]);
        }
        else if (found < -1)
        {
            int realOne = ~found - 1;
            Console.WriteLine("Biggest number than {0}, is {1}, the index of this thing is ", searched, array[realOne], realOne);
        }
    }
}

