using System;
using System.Collections.Generic;
/*Write a program that reads two arrays from the console and compares them element by element.
 * 
 * Yep it's probably better to make it with list, so we won't need the first two inputs. 
 */

class CompareTwoArrays          
{
    static void Main()
    {
        int elementsInFirst;
        int elementsInSecond;

        do
        {
            Console.Write("Enter how many numbers you want in first array: ");
        } while (!int.TryParse(Console.ReadLine(), out elementsInFirst));

        do
        {
            Console.Write("Enter how many numbers you want in first array: ");
        } while (!int.TryParse(Console.ReadLine(), out elementsInSecond));

        bool areEqual = true;
        if (elementsInFirst == elementsInSecond)
        {
            
            int[] firstArray = new int[elementsInFirst];
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Now, here we expect elements for the first array: ");
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            int[] secondArray = new int[elementsInFirst];
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("Here you should enter the elements for the second array: ");
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }
        }
        else
        {
            areEqual = false;
        }
        Console.WriteLine("Arrays are equal = {0}", areEqual);
    }

}

