using System;

/*Write a program that gets two numbers from the console and prints the greater of them. 
 * Don’t use if statements.*/

class GreaterFromTwo
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        
        string check;
        
        check = (firstNum> secondNum) ? "Your first number is bigger" : "Your second number is bigger";
        
        Console.WriteLine(check);       
    }
}

