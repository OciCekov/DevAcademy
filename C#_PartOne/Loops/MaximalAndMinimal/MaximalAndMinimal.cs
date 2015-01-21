using System;

/*  Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
*/

class MaximalAndMinimal
{
    static void Main()
    {
        Console.Write("Please enter how much numbers you want to sort: ");
        int numbers = int.Parse(Console.ReadLine());
        int[] arr = new int[numbers];

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("Now enter the {0} number: ", i + 1 );
            arr[i] = int.Parse(Console.ReadLine()); 
        }
        
        int biggestN = arr[0];
        int smallestN = arr[0];

        for (int i = 0; i < numbers; i++)
        {
            if (biggestN < arr[i])
            {
                biggestN = arr[i];
            }
            else if (smallestN > arr[i])
            {
                smallestN = arr[i];
            }
        }
        Console.WriteLine("Smallest number was: {0}", smallestN);
        Console.WriteLine("Biggest number was: {0}", biggestN);

    }
}
