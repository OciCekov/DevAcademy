using System;

//Write a program that reads 3 integer numbers from the console and prints their sum.

class ThreeNumbersSum
{
    static void Main()
    {
        Console.Write("Please enter  first number: ");
        string first = Console.ReadLine();

        Console.Write("Please enter second number: ");
        string second = Console.ReadLine();
        
        Console.Write("Please enter third number: ");
        string third = Console.ReadLine();
        
        int firstNum;
        int secondNum;
        int thirdNum;
        
        bool checkFirst = int.TryParse(first, out firstNum);
        bool checkSecond = int.TryParse(second, out secondNum);
        bool checkThird = int.TryParse(third, out thirdNum);
        
        if (checkFirst && checkSecond && checkThird)
        {
            Console.WriteLine("Sum of your numbers is: {0}", firstNum + secondNum + thirdNum);
        }
       
        else if (checkFirst == false && checkSecond == true && checkThird == true)
        {
            Console.WriteLine("your first input wasn't a number!");
            Console.WriteLine("Anyway, here is a result from the other two: {0}",secondNum + thirdNum );
        }
       
        else if (checkFirst == true && checkSecond == false && checkThird== true)
        {
            Console.WriteLine("Your second input wasn't a number!");
            Console.WriteLine("Anyway, here is a result from the other two: {0}", firstNum + thirdNum);
        }
       
        else if (checkFirst == true && checkSecond == true && checkThird == false)
        {
            Console.WriteLine("Your third input wasn't a number!");
            Console.WriteLine("Anyway, here is a result from the other two: {0}", firstNum + secondNum);
        }

        else if (checkFirst == false && checkSecond == false && checkThird == false)
        {
            Console.WriteLine("Well... That's embarassing, 3 chances and no number...");
        }

        else if (checkFirst == false && checkSecond == false && checkThird == true)
        {
            Console.WriteLine("You need atleast two numbers to get some sum, anyway, you entered: {0}", thirdNum);
        }

        else if (checkFirst == false && checkSecond == true && checkThird == false)
        {
            Console.WriteLine(" Your third input wasn't a number, also, what's up with the first one?\n \"{0}\" doesn't look like a number", first);
        }

        else if (checkFirst == true && checkSecond == false && checkThird == false)
        {
            Console.WriteLine(" Almost made it\n This close\n Just a second\n Nope there can't be sum with only one number");
        }
    }
}

