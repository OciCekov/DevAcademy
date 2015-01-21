using System;
using System.Linq;

/*Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample" -> "elpmas".
 */

class ReverseString
{
    static void Main()
    {
        Console.Write("Type the word: ");
        string inputed = Console.ReadLine();
        inputed.Reverse();
        Console.WriteLine("Your word in reverse\" {0} \"", inputed);
    }
}

