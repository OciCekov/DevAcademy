using System;
using System.Collections.Generic;

/* Write a program to convert decimal numbers to their binary representation.
 * 
*/
    class DecimalToBinary
    {
        static int UserInput(string numberStr)
        {
            
            int number  ;
            while (!(int.TryParse(numberStr, out number)))
            {
                // BS stands for "Back stabing" ;)
                Console.Write("Don't try to BS me like that, please!\nTryAgain: ");
                numberStr = Console.ReadLine();
            }

            return number;
        }

        static List<int> ConversionToBinary(int number)
        {
            List<int> numberInBinary = new List<int>();
            
            while (number > 0) 
            {
                numberInBinary.Add(number %2);
                number /= 2;
            }
          
            return numberInBinary;
        }

        static void PrintBinaryNumber(List<int> number)
        {
            Console.Write("Binary representation is: ");
            for (int i = number.Count - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Please enter the number: ");
           
            List<int> inBinary = new List<int> (ConversionToBinary(UserInput(Console.ReadLine())));
            PrintBinaryNumber(inBinary);
        }
    }

