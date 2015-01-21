using System;
/* Write a program that applies bonus scores to given scores in the range [1..9]. 
 * The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
 * if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
 * If it is zero or if the value is not a digit, the program must report an error.
 * Use a switch statement and at the end print the calculated new value in the console.
 */ 
namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.Write("Enter your score [1..9]: ");
            int cleanScore;
           
            while (!int.TryParse(Console.ReadLine(), out cleanScore) || cleanScore < 1 || cleanScore > 9) 
            {
                Console.Write("Error, score have to be: \n1. A number! \n2. A number between 1 and 9!\nNext try: ");
            }
            
            switch(cleanScore)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Your score is: {0}", cleanScore * 10);
                    break;
                
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Your score is: {0}", cleanScore * 100);
                    break;
            
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Your score is : {0}", cleanScore * 1000);
                    break;
                
                //Because of the loop in the begining, we don't need default case. 
            }
        }
    }
}
