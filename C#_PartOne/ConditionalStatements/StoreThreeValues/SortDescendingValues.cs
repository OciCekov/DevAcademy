using System;

/*Sort 3 real values in descending order using nested if statements.
*/

namespace StoreThreeValues
{
    class SortDescendingValues
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNumber;
           
            while (!double.TryParse(Console.ReadLine(),out firstNumber))
            {
                Console.Write("Not a number, please try again: ", firstNumber);
            }

            Console.Write("Enter second number: ");
            double secondNumber;
            
            while (!double.TryParse(Console.ReadLine(),out secondNumber))
            {
                Console.Write("Well, I need a number, try again: ");
            }

            Console.Write("Enter third number: ");
            double thirdNumber;
            
            while (!double.TryParse(Console.ReadLine(), out thirdNumber))
            {
                Console.WriteLine("Not actually a number, and again: ");
            }

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    if (secondNumber > thirdNumber)
                    {
                        Console.WriteLine("It is like this: {0}, {1}, {2}",firstNumber, secondNumber, thirdNumber);
                    }
                    else
                    {
                        Console.WriteLine("It is like this: {0}, {1}, {2}", firstNumber, thirdNumber, secondNumber);
                    }
                }
                else
                {
                    Console.WriteLine("It is like this: {0}, {1}, {2}", thirdNumber, firstNumber, secondNumber);
                }
            }
            else if (secondNumber > thirdNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("It is like this: {0}, {1}, {2}",secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("It is like this: {0}, {1}, {2}", secondNumber, thirdNumber, firstNumber);
                }
            }
            else
            {
                Console.WriteLine("It is like this: {0}, {1}, {2}", thirdNumber, secondNumber, firstNumber );
            }
        }
    }
}
