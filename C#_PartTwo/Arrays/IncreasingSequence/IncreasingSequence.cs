using System;
using System.Collections.Generic;
/* Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
*/
                                                            
class IncreasingSequence
{
    static void Main()
    {
        Console.Write("How big should your array be: ");
        string input = Console.ReadLine();
        int lenght = int.Parse(input);

        int[] arr = new int[lenght];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter element: {0} = ", i+1);
            arr[i] = int.Parse(Console.ReadLine());
        
        }

        int membersCounter = 1;
        int firstMember = 0;
        int lastMember = 0;
        int change = 0;
        int longestCount = 0;
        for (int i = 0; i < lenght -1; i++)
        {
            if (arr[i] < arr[i + 1]) 
            {
                membersCounter++;
                if (membersCounter > longestCount) 
                {
                    longestCount = membersCounter;
                    change = firstMember;

                }
            }
            else
            {
                membersCounter = 1;
                lastMember = i + 1;
            }
        }
        for (int i = change; i < longestCount + change; i++)
        {
            Console.WriteLine(arr[i+1]);
        }

    }
}

