using System;

/* Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
   -Use the method from the previous exercise.
 * 
 *  Well the method from previous excercise couldn't be implemented correctly, so this is as close as I could make it.
 *  And yes, it's not close
 */


class FirstBiggerThanItsNeighbours
{
    static int[] UserInputedArray()
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

    static int CheckNeighbours(int whichMember, int[] testArray)
    {
        for (int i = whichMember; i < testArray.Length - 1; i++)
        {
            if ((testArray[whichMember] > testArray[whichMember - 1]) && (testArray[whichMember] > testArray[whichMember - 1]))
            {
                return whichMember;
            }
        }
        return -1;
    }
    static void Main()
    {
        int[] userInputed = UserInputedArray();

        int whichMember = 1;
        int check = CheckNeighbours(whichMember, userInputed);
        if (check != -1)
        {
            Console.WriteLine("The element is on position: {0}", check);
        }
        else
        {
            Console.WriteLine("There is no such element");
        }
    }
}

