using System;
/*Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
 */
class FromAnyToAny
{
    static int CheckUserInput(int fromWhich, int toWhich)
    {
        if (fromWhich < 2 || fromWhich > 16) 
        {
            return 1;
        }
        if (toWhich < 2|| toWhich > 16) 
        {
            return 2;
        }

        return 3;
    }

    static int ConvertToDecimal(string strNumber, int fromWhich)
    {
        strNumber.ToUpper();
        int numberInDeciaml = 0;
        int degree = strNumber.Length - 1;
        for (int i = 0; i < strNumber.Length; i++,degree--)
        {
            int inGiven = 0;
            
            switch (strNumber[i])
            {
                case 'A':
                    inGiven = 10;
                    break;
                case 'B':
                    inGiven = 11;
                    break;
                case 'C':
                    inGiven = 12;
                    break;
                case 'D':
                    inGiven = 13;
                    break;
                case 'E':
                    inGiven = 14;
                    break;
                case 'F':
                    inGiven = 15;
                    break;
                default:
                    inGiven = strNumber[i] - 48;
                    break;
            }
            numberInDeciaml += inGiven * (int)Math.Pow(fromWhich, degree);
        }
        return numberInDeciaml;
    }

    static string ConvertToUserChoice(int numberInDecimal, int toWhich)
    {
        int remainder = 0;
        string strInGivenSystem = null;
        while (true)
        {
            remainder = numberInDecimal % toWhich;

            switch (remainder)
            {
                case 10:
                    strInGivenSystem += "A";
                    break;
                case 11:
                    strInGivenSystem += "B";
                    break;
                case 12:
                    strInGivenSystem += "C";
                    break;
                case 13:
                    strInGivenSystem += "D";
                    break;
                case 14:
                    strInGivenSystem += "E";
                    break;
                case 15:
                    strInGivenSystem += "F";
                    break;
                default:
                    strInGivenSystem += remainder.ToString();
                    break;
            }
            numberInDecimal /= toWhich;
            if (numberInDecimal == 0)
            {
                break;
            }
        }

        return strInGivenSystem;
    }
    static void Main()
    {
        Console.Write("Enter the number: ");
        string strNumber = Console.ReadLine();

        Console.Write("Enter from which numeral system it is: ");
        int fromWhich = int.Parse(Console.ReadLine());

        Console.Write("Enter in which numeral system would you like to see it: ");
        int toWhich = int.Parse(Console.ReadLine());
        
        int isValid =  CheckUserInput(fromWhich,toWhich);

        if (isValid == 1) 
        {
            Console.WriteLine("Soryy you've entered wrong system to convert from!");
            return;
        }

        if (isValid == 2)
        {
            Console.WriteLine("Sorry you've entered wrong system to convert to!");
            return;
        }

        int toDecimal = ConvertToDecimal(strNumber, fromWhich);
        string strConverted = ConvertToUserChoice(toDecimal, toWhich);
        char[] finalResult = strConverted.ToCharArray();
        Console.Write("The number in chosen numeral sytem is: ");
        for (int i = finalResult.Length - 1; i >= 0; i--)
        {
            Console.Write(finalResult[i]);
        }
        Console.WriteLine();

    }
}