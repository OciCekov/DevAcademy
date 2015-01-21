using System;

/*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
Input:   Hi!
Output:   \u0048\u0069\u0021
 */
class ConvertToUnicode
{
    static void Main()
    {
        Console.Write("Enter a string   ");
        string input = Console.ReadLine();
        Console.Write("And this is the output: ");
        foreach (var letter in input)
        {
            Console.Write( "\\u{0:X4}", (int)letter);
        }
        Console.WriteLine();
    }
}

