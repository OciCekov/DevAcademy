using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program to convert binary numbers to hexadecimal numbers (directly).
*/

class BinaryToHexadecimal
{
    static string FillingWithZeros(string binaryInput)
    {
        for (int i = 4; i < 32; i *= 4)
        {
            if (binaryInput.Length < i)
            {
                string zeros = new String('0', i - binaryInput.Length);
                binaryInput = zeros + binaryInput;
                break;
            }
        }
        return binaryInput;
    }

    static StringBuilder Conversion(string binaryInput)
    {
        StringBuilder numberInHex = new StringBuilder();

        for (int i = 0; i < binaryInput.Length; i = i + 4)
        {
            switch (binaryInput.Substring(i, 4))
            {
                case "1010":
                    numberInHex.Append("A");
                    break;
                case "1011":
                    numberInHex.Append("B");
                    break;
                case "1100":
                    numberInHex.Append("C");
                    break;
                case "1101":
                    numberInHex.Append("D");
                    break;
                case "1110":
                    numberInHex.Append("E");
                    break;
                case "1111":
                    numberInHex.Append("F");
                    break;
                case "0000":
                    numberInHex.Append("0");
                    break;
                case "0001":
                    numberInHex.Append("1");
                    break;
                case "0010":
                    numberInHex.Append("2");
                    break;
                case "0011":
                    numberInHex.Append("3");
                    break;
                case "0100":
                    numberInHex.Append("4");
                    break;
                case "0101":
                    numberInHex.Append("5");
                    break;
                case "0110":
                    numberInHex.Append("6");
                    break;
                case "0111":
                    numberInHex.Append("7");
                    break;
                case "1000":
                    numberInHex.Append("8");
                    break;
                case "1001":
                    numberInHex.Append("9");
                    break;
            }
        }
        return numberInHex;
    }
    static void Main()
    {
        Console.Write("Enter the number: ");
        string binaryInput = FillingWithZeros(Console.ReadLine());
        StringBuilder converted
            = Conversion(binaryInput);

        Console.WriteLine("The number in Hexadecimal is: 0x"+converted);
        

    }
}

