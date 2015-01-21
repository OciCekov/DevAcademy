using System;

    /* Write a program that reads your age from the console
    and print how old you will be after 10 years*/

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Please input current age: ");
        int currentYears = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("You were born in {0}: ", 2013 - currentYears);
        Console.WriteLine("After 10 years you will be {0}: \n", currentYears + 10 );
    }
}

