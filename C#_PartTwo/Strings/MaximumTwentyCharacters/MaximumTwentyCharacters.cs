using System;

/*Write a program that reads from the console a string of maximum 20 characters.
 * If the length of the string is less than 20, 
 * the rest of the characters should be filled with '*'. 
 * Print the result string into the console 
 */
class MaximumTwentyCharacters
{
    static void Main()
    {
        Console.Write("Enter the string: ");
        string userInput = Console.ReadLine();
        int maxLength = 20;
        if (userInput.Length < maxLength)
        {
            Console.WriteLine("Here is your new string: {0}",userInput.PadRight(maxLength, '*'));
        }
        else if (userInput.Length > maxLength)
        {
            Console.WriteLine("Sorry this should be shorter than 20 characters");
        }
        else if (userInput.Length == maxLength)
        {
            Console.WriteLine("There was nothing to be added");
        }
    }
}

