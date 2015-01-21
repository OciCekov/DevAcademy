using System;

/*Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.
 */

class RepeatingNumber
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

    static int CheckArray(int[] array,int whichNumber)
    {
        int howMany = 0;
        
        foreach (var number in array)
        {
            if (number == whichNumber)
            {
                howMany++;                
            }
        }
        
        
        return howMany;
    }
    
    static void Main()
    {
        Console.WriteLine("Now here are your choices:");
        Console.WriteLine("1: Hardcoded array\n2: You can input an array");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("This example is given with 32");
            int whichNumber = 32;
            int[] array = new int[] { 2, 86, 89, 32, 23, 32, 23, 65, 32, 2, 56, -5 };
           
            Console.WriteLine("So, 32 is typed: "+CheckArray(array, whichNumber)+ " times");   
        }
        else if (choice == 2)
        {
            Console.WriteLine("So, you've decided, to try it!");
            int[] array = UserInputedArray();        
           
            Console.Write("And which number should we check: ");
            int whichNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("In this case, {0} is typed {1} times", whichNumber, CheckArray(array, whichNumber));

        }
        else
        {
            Console.WriteLine("Error! Sorry, there are only two options!");
        }
    }
}