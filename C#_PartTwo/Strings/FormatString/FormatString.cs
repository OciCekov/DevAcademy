using System;

/* Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
 * Format the output aligned right in 15 symbols.
 */

class FormatString
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int enteredNumber;
        while (!int.TryParse(input, out enteredNumber))
        {
            Console.Write("This wasn't actually a number, wasn't it?\nTry Again:  ");
            input = Console.ReadLine();
        }
        Console.WriteLine("{0,15} -  Deciaml", enteredNumber);
        Console.WriteLine("{0,15:X} - Hexadecimal", enteredNumber);
        Console.WriteLine("{0,15:P} - Pecentage", enteredNumber);  
        Console.WriteLine("{0,15:E} - Scientific notation", enteredNumber);
    }
}

