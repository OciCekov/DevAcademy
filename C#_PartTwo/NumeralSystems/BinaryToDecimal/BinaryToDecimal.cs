using System;


/* Write a program to convert binary numbers to their decimal representation.
*/

class BinaryToDecimal
{
    static int UserInput(string numberStr)
    {

        int number;
        while (!(int.TryParse(numberStr, out number)))
        {
            // BS stands for "Back stabing" ;)
            Console.Write("Don't try to BS me like that, please!\nTryAgain: ");
            numberStr = Console.ReadLine();
        }        
     
        return number;
    }
    
    static int Pow (int sqr)
    {
        //Thanks to Ilian Ivanov, for this idea.
        return (1 << (sqr * 4));
    }

    static long ConversionToBinary(int number)
    {
        string inputStr = number.ToString();

        long sum = 0;
        for (int i = 0; i < inputStr.Length; i++)
        {
            sum += (number % 10) * Pow(i);
            number /= 10;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Please enter the number: ");
        int userInput = UserInput(Console.ReadLine());

        long numberInDecimal = ConversionToBinary(userInput);
        Console.WriteLine("The number in decimal is: " + numberInDecimal);
    }
}

