using System;
using System.Collections.Generic;

/*  Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.
*/


class EqualElements
{
    static void Main()
    {
        Console.Write("How many elements would you like to be in this array? ");
        string lenght = Console.ReadLine();
        int arrLenght = int.Parse(lenght);

        int[] theArray = new int[arrLenght];
        for (int i = 0; i < theArray.Length; i++)
        {
            Console.Write("Enter element number{0}: ", i + 1);
            theArray[i] = int.Parse(Console.ReadLine());
        }


        int howMany = 1;
        int what = 0;
        int change = 0;

        for (int i = 0; i < theArray.Length - 1; i++) 
        {
            if (theArray[i] == theArray[i + 1]) 
            {
                howMany++;
                if (howMany > change)
                {
                    change = howMany;
                    what = theArray[i];
                }
            }
            else
            {
                howMany = 1;
            }

        }
        
        
         Console.WriteLine("You've entered number: {0}, {1} - times.", what, change);
        
    }
}

