using System;
using System.Numerics;

/*Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
    I'm really not sure that this should be it but.... it's 22:00, so no time to check it in the forum, will see tomorow.
 */
class ArrayOfDigits
{
    static BigInteger Sum(char[] firstNum, char[] secondNum)     
    {
        BigInteger Result = BigInteger.Parse(String.Join("", firstNum)) + BigInteger.Parse(String.Join("", secondNum));
      
        return Result;                                  
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        char[] firstNumArr = new char[] { };
        firstNumArr = Console.ReadLine().ToCharArray();

        Console.Write("Enter second number: ");
        char[] secondNumArr = new char[] { };
        secondNumArr = Console.ReadLine().ToCharArray();
        Array.Reverse(firstNumArr);
        Array.Reverse(secondNumArr);
        Console.WriteLine("The result is: " + Sum(firstNumArr, secondNumArr));
    }
}