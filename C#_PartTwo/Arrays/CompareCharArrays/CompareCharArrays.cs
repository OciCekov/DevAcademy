using System;
using System.Collections.Generic;
/* Write a program that compares two char arrays lexicographically (letter by letter).
*/
namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            Console.Write("enter how big would you arrays to be:");
            string strFirst = Console.ReadLine();
            int lenghts = int.Parse(strFirst);
            
            char[] firstArr = new char[lenghts];
            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write("Enter letters for first array: ");
                firstArr[i] = char.Parse(Console.ReadLine());
            }

            char[] secondArr = new char[lenghts];
            for (int i = 0; i < secondArr.Length; i++)
            {
                Console.Write("Enter letter for second array: ");
                secondArr[i] = char.Parse(Console.ReadLine());
            }

            int firstBigger = 0;
            int secondBigger = 0;
            int equal = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    equal++;
                }
                else if (firstArr[i]> secondArr[i]) 
                {
                    firstBigger++;
                }
                else if (firstArr[i] < secondArr[i])
                {
                    secondBigger++;
                }
            }
            if (equal > firstBigger && equal > secondBigger)
            {
                Console.WriteLine("The arrays are equal! ");
            }
            else if (firstBigger > secondBigger) 
            {
                Console.WriteLine("The first array is bigger! ");   //I wasn't 100% what should be printed here
            }
            else if (secondBigger>firstBigger)
            {
                Console.WriteLine("The second array is biger! ");
            }



            
        }
    }
}
