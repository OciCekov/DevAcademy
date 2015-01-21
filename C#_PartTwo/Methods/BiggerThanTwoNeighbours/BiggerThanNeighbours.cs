using System;

/* Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
 */

class BiggerThanNeighbours
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
    static bool ValidateUserInput(int whichMember, int[] testArray)
    {
        if ((whichMember > testArray.Length) || (whichMember < 0))
        {
            return false;
        }
        return true;
    }

    static int CheckNeighbours(int whichMember, int[] testArray)
    {
        if (whichMember == 0)
        {
            return 2;
        }
        else if (whichMember == testArray.Length - 1)
        {
            return 3;
        }
        else if ((testArray[whichMember] > testArray[whichMember - 1]) && (testArray[whichMember] > testArray[whichMember + 1]))
        {
            return 1;
        }
        return 4;
    }
    static void Main()
    {
        int[] userInputed = UserInputedArray();
        Console.Write("Input which member of the array should be checked: ");
        int whichMember = int.Parse(Console.ReadLine());

        bool wrongInput = ValidateUserInput(whichMember, userInputed);

        if (wrongInput == false)
        {
            Console.WriteLine("Sorry. No position: {0} in the array", whichMember);
        }
        else
        {
            int check = CheckNeighbours(whichMember, userInputed);
            if (check == 1)
            {
                Console.WriteLine("The member at position {0}, is bigger than it's neighbours", whichMember);
            }
            else if (check == 2)
            {
                Console.WriteLine("Sorry member at postion {0} doesn't have left neighbour", whichMember);
            }
            else if (check == 3)
            {
                Console.WriteLine("Sorry member at position {0} doesn't have right neighbour", whichMember);
            }
        }
    }
}

