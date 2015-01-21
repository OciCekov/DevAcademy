using System;

/*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
*/

namespace NumbersToN
{
    class NumbersToN
    {
        static void Main()
        {
            int start = 1;
            Console.Write("Enter the number: ");
            int finalNumber;            
           
            while (!int.TryParse(Console.ReadLine(), out finalNumber)) 
            {
                Console.Write("This wasn't a number, try again: ");               
            }   
            
            while (finalNumber!= start)
            {
                Console.WriteLine("{0}",start);
                start++;
            }
        }
    }
}
