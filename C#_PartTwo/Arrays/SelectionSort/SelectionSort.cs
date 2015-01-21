using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Sorting an array means to arrange its elements in increasing order. 
 * Write a program to sort an array. Use the "selection sort" algorithm: 
 * Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.
 */
class SelectionSort
{
    static void Main()
    {

        Console.WriteLine("Whenever you think, that's enough, enter: \"stop\" ");

        List<int> unsorted = new List<int>();
        
        for (int i = 0; i > int.MinValue; i++)
        {

            Console.Write("Enter number: ");

            string inputStr = Console.ReadLine();
           
            if (inputStr == "stop")
            {
                break;
            }
            
            int input = int.Parse(inputStr);
            unsorted.Add(input);
        }

        int exchangePurpose = 0;

        for (int i = 0; i < unsorted.Count - 1; i++)
        {
            for (int j = i + 1; j < unsorted.Count; j++)
            {
                if (unsorted[i] > unsorted[j])
                {
                    exchangePurpose = unsorted[j];
                    unsorted[j] = unsorted[i];
                    unsorted[i] = exchangePurpose;
                }
            }


        }
        for (int i = 0; i < unsorted.Count; i++)
        {
            Console.WriteLine(unsorted[i]);
        }

    }
}

