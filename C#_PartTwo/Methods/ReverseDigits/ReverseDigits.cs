using System;

/* Write a method that reverses the digits of given decimal number. Example: 256 -> 652
*/

class ReverseDigits
{
    static string ReverseNumber(string inputStr)
    {
        char[] digits = inputStr.ToCharArray();
        Array.Reverse(digits);

        return new string(digits);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        string stringNum = Console.ReadLine();
        string stringReversed = ReverseNumber(stringNum); 
        Console.WriteLine("The reversed number is: " + stringReversed);
    }
}

