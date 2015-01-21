using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DeciamlToHexadecimal
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
        if (number < 0 )
        {
            Console.WriteLine("{0} * (-1) = {1}", number, number *-1);
            return number *= -1;
        }

        return number;
    }

    static string Conversion(int input)
    {
        string numberToHex = null;
        while (input != 0)
        {
            if (input % 16 > 9)
            {
                switch (input % 16)
                {
                    case 10: 
                        numberToHex = "A" + numberToHex;
                        break;
                    case 11: 
                        numberToHex = "B" + numberToHex; 
                        break;
                    case 12: 
                        numberToHex = "C" + numberToHex;
                        break;
                    case 13: 
                        numberToHex = "D" + numberToHex; 
                        break;
                    case 14: 
                        numberToHex = "E" + numberToHex;
                        break;
                    case 15: 
                        numberToHex = "F" + numberToHex; 
                        break;
                }
            }
            else
            {
                numberToHex = input % 16 + numberToHex;
            }
            input = input / 16;
            
        }
        return numberToHex;
    }
    static void Main()
    {
        Console.Write("Enter the number in decimal: ");
        int decimalInput = UserInput (Console.ReadLine());
        string numberInHex = Conversion(decimalInput);
        Console.WriteLine("The number in hexadecimal is: " + numberInHex);
        
    }
}

