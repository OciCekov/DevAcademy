using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
    
 */
class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Whenever you want to end, type \"end\" ");
        List<int> list = new List<int>();

        for (int i = 0; i < int.MaxValue; i++)
        {
            Console.Write("Now enter the numbers that you have in mind: ");
            string check = Console.ReadLine();
           
            if (check == "end")
            {
                Console.WriteLine("Thanks, now some magic will be done.");
                break;
            }

            int filling = int.Parse(check);
            list.Add(filling);
        }
        Console.WriteLine();
        int maxTillNow = list[0];
        int maxEnd = list[0];

        int start = 0;
        int tempStart = 0;
        int finallyOver = 0;

        for (int i = 1; i < list.Count; i++)
        {
            if (maxEnd < 0)
            {
                maxEnd = list[i];
                tempStart = i;
            }

            else
            {
                maxEnd += list[i];
            }

            if (maxEnd > maxTillNow)
            {
                maxTillNow = maxEnd;
                start = tempStart;
                finallyOver = i;
            }
        }
        Console.Write("Some stolen from wikipedia magic happened, here is the reult: ");

        for (int i = start; i < finallyOver + 1; i++)
        {
            Console.Write(list[i] + "  ");
        }
        Console.WriteLine();
    }
}

