using System;

/*Declare two string variables and assign them with following value:
 * "The "use" of quotations causes difficulties"
 *Do the above in two different ways: with and without using quoted strings.
 */

class TwoWaysWithStrings
{
    static void Main()
    {
        Console.WriteLine("Choose whichever one you wont to see \"1\" for first method, \"2\" for second");
        string first = @"The ""use"" of quotations causes difficulties!";
        string second = "The \"use\" of quotations causes difficulties.";
        int TypeFirst = int.Parse(Console.ReadLine());

        if (TypeFirst == (1))
        {
            Console.WriteLine(first);
        }
        else 
        {
            Console.WriteLine(second);
        }
            
    }
}

