using System;

/* Write a program that finds the biggest of three integers using nested if statements.
*/


class BiggestOfThree
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        int firstInt;
        while (!int.TryParse(Console.ReadLine(), out firstInt))
        {
            Console.Write("A number please: ");
        }
                
        Console.Write("Please enter the second number: ");
        int secondInt;
        while (!int.TryParse(Console.ReadLine(), out secondInt))
        {
            Console.Write("Let it be a number, this can't work with letters, another try: ");
        }

        Console.Write("Now it's time for third number: ");
        int thirdInt;
        while (!int.TryParse(Console.ReadLine(), out thirdInt))
        {
            Console.Write("Experimenting with letter? Fail! Now please try again with number: ");
        }

        if (firstInt > secondInt)
        {
            firstInt = secondInt;
            if (firstInt > thirdInt)
            {
                Console.WriteLine("First number is the biggest.");
            }
            else
            {
                Console.WriteLine("Third number is the biggest.");
            }

        }
        else
        {
            firstInt = secondInt;
            if (firstInt < thirdInt)
            {
                Console.WriteLine("Third number is the biggest.");
            }
            else
            {
                Console.WriteLine("Second number is the biggest.");
            }
        }
    }
}

