using System;
using System.Text;
/*Write a program to convert hexadecimal numbers to binary numbers (directly).
*/



    class HexadecimalToBinary
    {
        static StringBuilder Conversion(string input)
        {
            StringBuilder inBinary = new StringBuilder();
            foreach (char digit in input)
            {
                switch (digit)
                {
                    case '0':
                        inBinary.Append("0000 ");
                        break;
                    case'1':
                        inBinary.Append("0001 ");
                        break;
                    case '2':
                        inBinary.Append("0010 ");
                        break;
                    case'3':
                        inBinary.Append("0011 ");
                        break;
                    case'4':
                        inBinary.Append("0100 ");
                        break;
                    case'5':
                        inBinary.Append("0101 ");
                        break;
                    case'6':
                        inBinary.Append("0110 ");
                        break;
                    case '7':
                        inBinary.Append("0111 ");
                        break;
                    case '8':
                        inBinary.Append("1000 ");
                        break;
                    case'9':
                        inBinary.Append("1001 ");
                        break;
                    case 'A':
                        inBinary.Append("1010 ");
                        break;
                    case 'B':
                        inBinary.Append("1011 ");
                        break;
                    case 'C':
                        inBinary.Append("1100 ");
                        break;
                    case'D':
                        inBinary.Append("1101 ");
                        break;
                    case'E':
                        inBinary.Append("1110 ");
                        break;
                    case'F':
                        inBinary.Append("1111 ");
                        break;
                    default:
                        Console.Write("Sorry, out of hexadecimal!");
                        break;
                }
            }                       
            return inBinary;
        }
        static void Main()
        {
            Console.Write("Enter hex number (without 0x): ");
            string input = Console.ReadLine().ToUpper();
            StringBuilder converted = Conversion(input);
            Console.WriteLine("Aaaand the number is: "+converted);
        }
    }

