using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
 */ 
class ReverseWords
{
    static void Main()
    {
      
        string input = "C# is not C++, not PHP and not Delphi!";
        string[] splitChars = new string[]{" ", ", ", ",", "!"};
        string[] inputSentence = input.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < inputSentence.Length-1; i++)
        {
            if (inputSentence[i] == "C++")
            {
                Console.Write(",");
            }
            Console.Write(inputSentence[i] + " ");
        }
        Console.WriteLine("!");
        Console.WriteLine();
    }
}

