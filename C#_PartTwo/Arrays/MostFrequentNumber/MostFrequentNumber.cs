using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
 */

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            Console.Write("How long should be the array: ");

            int lenght;
            while (!int.TryParse(Console.ReadLine(), out lenght))
            {
                Console.Write("Hey buddy, you've entered a letter, this is just wrong! \nTry agaain please: ");
            }
            int[] array = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Now fill the thing up: ");

                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.Write("Please don't do that! \nAgain: ");
                }
            }

            int howMany = 1;
            int whatElement = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }
                if (counter > howMany)
                {
                    howMany = counter;
                    whatElement = array[i];
                }
            }

            if (howMany > 1)
            {
                Console.WriteLine("You've entered {0}, {1} times", whatElement, howMany);      
            }
            else
            {
                Console.WriteLine("You've entered totaly different numbers, so there is no most frequent");
            }
        }
    }
}
