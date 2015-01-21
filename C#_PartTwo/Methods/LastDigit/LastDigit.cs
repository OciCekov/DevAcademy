using System;
using Microsoft.VisualBasic;
/* Write a method that returns the last digit of given integer as an English word. Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".
 * Yes, this could be with simple array, anyway I wanted to try the switch.
 */

class LastDigit
{
    static void Choice(int number)  
    {
        Console.Write("The Last number is: ");
        switch (number)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                break;
        }
    }    
    static void Main()
    {
        Console.Write("Enter the number : ");
        string num = Console.ReadLine();

        //It works only if you add a reference Microsoft.VisualBasic
        string lastChar = Strings.Right(num, 1); 
        int lastNumber = int.Parse(lastChar);
       
        Choice(lastNumber);
    }
   
}

