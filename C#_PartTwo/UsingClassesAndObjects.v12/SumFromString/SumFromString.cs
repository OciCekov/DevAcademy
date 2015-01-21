using System;

/* You are given a sequence of positive integer values written into a string, separated by spaces. 
 * Write a function that reads these values from given string and calculates their sum. Example:
 * string = "43 68 9 23 318" -> result = 461
 */

class SumFromString
{
    static void Main()
    {
        Console.Write("Enter the string with numbers: ");
        string inputStr = Console.ReadLine();
        
        int sum = 0;
        string[] numbersStr = inputStr.Split(' ');
 
        foreach (string number in numbersStr)
        {
            sum += int.Parse(number);
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}

