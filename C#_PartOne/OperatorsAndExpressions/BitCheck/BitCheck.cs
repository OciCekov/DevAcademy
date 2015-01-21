using System;

/*Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1.
Example: v=5; p=1 -> false.*/

class BitCheck
{
    static void Main()
    {
        Console.Write("Please enter desired number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Please enter desired bit position: ");
        int position = int.Parse(Console.ReadLine());
        int movement = 1 << position;
        int sum = num & movement;
        int final = sum >> position;
        if (final == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

