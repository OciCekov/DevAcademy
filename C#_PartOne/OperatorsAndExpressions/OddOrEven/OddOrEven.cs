using System;

//Write an expression that checks if given integer is odd or even.

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        string input = Console.ReadLine();
        int number;
        if (int.TryParse( input, out number))
        {
            int find = number % 2;
            bool solut = (find == 0);
            if (solut == true)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
        }
        else
        {
            Console.WriteLine("Please try again, with a number this time.");
        }
    }
}

