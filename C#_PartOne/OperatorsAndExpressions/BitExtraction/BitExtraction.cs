using System;

/*  Write an expression that extracts from a given integer i the value of a given bit number b.
 * Example: i=5; b=2 -> value=1.
 */


class BitExtraction
{
    static void Main()
    {
        Console.Write("Enter desired number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position that you require: ");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int compare = mask & num;
        int final = compare >> position;
        Console.WriteLine("Bit in the requested position is: {0}", final);
    }
}

