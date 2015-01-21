using System;

 //Create console application that prints your first and last name. 

class PrintFirstAndLastName
{
    static void Main()
    {
        Console.Write("Please input first name: ");
        string firstName = (Console.ReadLine());
        Console.Write("Please input Last name: ");
        string lastName =  (Console.ReadLine());
        Console.WriteLine("Your first and last name is: {0} {1}", firstName, lastName);       
    }
}

