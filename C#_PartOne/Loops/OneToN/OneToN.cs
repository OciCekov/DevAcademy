using System;

/* Write a program that prints all the numbers from 1 to N.
*/

class OneToN
{
    static void Main()
    {
        int numberN;
        
        do
        {
            Console.Write("Please enter valid number: ");
     
        } while (!int.TryParse(Console.ReadLine(),out numberN));
        
        if (numberN > 0)
        {   
            for (int i = 1; i <= numberN; i++)
            {            
                Console.WriteLine(i);
            }
        }

        else
        {
            for (int i = 1; i >= numberN; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

