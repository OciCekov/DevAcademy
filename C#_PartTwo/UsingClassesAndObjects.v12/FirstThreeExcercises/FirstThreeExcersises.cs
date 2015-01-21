using System;
// Theese 3 were really short so I made them like this, just because I really disliked the idea of giving one excercise on one row. 
class FirstThreeExcersises
{
    // Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
    static void IsLeapYear()
    {        
        Console.Write("Enter which year should we check: ");
        int currentYear = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(currentYear);

        if (isLeap)
        {
            Console.WriteLine("The year {0} is leap", currentYear);
        }
        else
        {
            Console.WriteLine("The year {0} is not leap", currentYear);
        }
    }
    // Write a program that generates and prints to the console 10 random values in the range [100, 200].
    static void TenRandomValues()
    {
        Random generateRandom = new Random();

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine("Random number {0}:  {1}", i, generateRandom.Next(100, 200));
        }
    }
    // Write a program that prints to the console which day of the week is today. Use System.DateTime.
    static void WhichDayIsToday()
    {
        Console.WriteLine(DateTime.Now.ToString("dddd"));
    }
    
    static void Main()
    {
        Console.WriteLine("Here are the first three excersises, you can choose whichever you want want to see\n");
        Console.WriteLine("Enter 1 to check for leap year\nEnter 2 to see 10 random numbers");
        Console.WriteLine("Enter 3 to see what day is today\nEnter 4 to see all of them");
        Console.Write("Your choice: ");
        int userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1) 
        {
            IsLeapYear();
        }
        if (userChoice == 2) 
        {
            TenRandomValues();
        }
        if (userChoice == 3) 
        {
            WhichDayIsToday();
        }
        if (userChoice == 4) 
        {
            IsLeapYear();
            TenRandomValues();
            WhichDayIsToday();
        }
        else
        {
            Console.WriteLine("Sorry, no such option");
        }
    }
}

