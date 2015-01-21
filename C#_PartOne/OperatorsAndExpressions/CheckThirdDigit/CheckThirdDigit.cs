using System;

/*Write an expression that checks for given integer if its third digit (right-to-left) is 7. 
 * E. g. 1732 -> true.
 */

class CheckThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Please enter the number to be checked(it needs to consist at least 3 digits): ");
        string number = Console.ReadLine();
        int wholeNumber;
        if  (int.TryParse(number, out wholeNumber))
        {
            int moving = wholeNumber / 100;
            int final = moving % 10;
            Console.WriteLine("The digit is:{0}",final);
            if (final == 7)
            {
                Console.WriteLine("Is {0} = 7, yep.",final);
            }
            else
            {
                Console.WriteLine("Is {0} = 7, nope.", final);
            }
        }
        else
        {
            Console.WriteLine("Please try again with number!");
        }
    }
}

