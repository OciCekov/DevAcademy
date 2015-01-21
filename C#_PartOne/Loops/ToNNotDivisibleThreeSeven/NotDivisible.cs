using System;

/* Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
*/

class NotDivisible
{
    static void Main()
    {
        int inputN;
      
        do
        {
            Console.Write("Please enter a nuber: ");
        } while (!int.TryParse(Console.ReadLine(), out inputN));

        if (inputN > 0)
        {
            
            for (int i = 1; i <= inputN; i++)
            {

                if (i % 21 == 0)        //it it 21 because 3 * 7 = 21
                {
                    continue;
                }
                
                Console.WriteLine(i);
            }
        }
       
        else
        {
            for (int i = 1; i >= inputN; i--)
            {
                
                if (i % 21 == 0)
                {
                    continue;
                }
                
                Console.WriteLine(i);
            }
        }
    }
}

