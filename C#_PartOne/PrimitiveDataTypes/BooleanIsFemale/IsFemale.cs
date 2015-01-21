using System;

/*Declare a boolean variable called isFemale 
 * and assign an appropriate value corresponding to your gender.
 */

class IsFemale
{
    static void Main()
    {
        Console.WriteLine("Please enter \"f\" for female");
        bool isFemale;
        string read = Console.ReadLine();
        if (read == "f")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.WriteLine("{0} that you are a female \n", isFemale);
    }
}

