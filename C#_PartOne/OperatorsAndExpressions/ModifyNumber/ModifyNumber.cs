using System;

/*We are given integer number n, value v (v=0 or 1) and a position p.
 * Write a sequence of operators that modifies n to hold the value v at the position p
 * from the binary representation of n.
 *Example: n = 5 (00000101), p=3, v=1 => 13 (00001101)
 *n = 5 (00000101), p=2, v=0 => 1 (00000001)
 */

class ModifyNumber
{
    static void Main()
    {
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Please enter bit value (0 or 1): ");
        int value = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int bitValue = number & mask;
        if (bitValue == 0)
        {
            number = number | mask; 
            Console.WriteLine("After changes were applied, your number is: {0}", number);
        }
        else
        {
            number = number & (~ mask);
            Console.WriteLine("After changes were applied, your number is: {0}", number);
        }


    }
}

