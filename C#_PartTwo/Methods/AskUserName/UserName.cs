using System;

/* Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
 * Write a program to test this method.
 */

class UserName
{
    static void Merge()
    {
        string input = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", input);
    }

    static void Main()
    {
        // Is this better to be here or in the method? 
        Console.Write("Enter your name: ");    
       
        Merge();
    }
}