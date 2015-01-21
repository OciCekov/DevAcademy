using System;

/*Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
*/

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int input = int.Parse(Console.ReadLine());
        int sum = 0;
              
        for (int i = 0; i < input; i++)
        {
            Console.Write("Enter the numbers: ");
            int final = int.Parse(Console.ReadLine());
            sum = sum + final;
        }
        Console.WriteLine("the sum of the numbers is: "+ sum );
    }
}

