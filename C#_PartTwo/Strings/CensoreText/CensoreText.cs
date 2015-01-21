using System;
/* We are given a string containing a list of forbidden words and a text containing some of these words. 
 * Write a program that replaces the forbidden words with asterisks. Example:
 * input - Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
 * output - ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */
class CensoredText
{
    static void Main()
    {
        string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] censor = { "Microsoft", "CLR", " PHP " };
        int length = censor.Length;

        for (int i = 0; i < length; i++)
        {
            input = input.Replace(censor[i], new string('*', censor[i].Length));
        }
        Console.WriteLine(input);
    }
}