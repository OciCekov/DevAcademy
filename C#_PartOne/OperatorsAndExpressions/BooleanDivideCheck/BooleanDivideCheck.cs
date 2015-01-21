using System;
/*Write a boolean expression that checks for given integer
 * if it can be divided (without remainder) by 7 and 5 in the same time.
 */


class BooleanDivideCheck
{
    static void Main()
    {
        Console.Write("Please enter your number: ");
        string userInput = Console.ReadLine();
        int testNumber;
        if (int.TryParse( userInput, out testNumber))
        {
            int check = testNumber % 5 | testNumber % 7;   //It also can be done only with "testNumber % 35" 
            bool result = (check == 0);
            if (result == true)
            {
                Console.WriteLine("Your number is divisible by both 5 and 7");
            }
            else
            {
                Console.WriteLine("Your number is not divisible by both 5 and 7");
            }
        }
        else
        {
            Console.WriteLine("You can't divide letters, please enter a number.");
        }
    }
}

