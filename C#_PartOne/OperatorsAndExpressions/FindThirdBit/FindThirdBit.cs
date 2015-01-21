using System;

/* Write a boolean expression for finding if the bit 3 (counting from 0)
 * of a given integer is 1 or 0.
 */

class FindThirdBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int inputCheck; 
        if (int.TryParse(input, out inputCheck))
        {
            int moves = 3;
            int mask = 1 << moves;
            int compare = inputCheck & mask;
            int result = compare >> moves;
            Console.WriteLine("The bit that you were looking for is: {0}", result);

        }
        else
        {
            Console.WriteLine("This should be a number!");
        }
       
    }
}
             
