using System;

/* Write a program to convert hexadecimal numbers to their decimal representation.
*/

    class HexadecimalToDecimal
    {
        static int Pow(int sqr)
        {
            //Thanks to Ilian Ivanov, for this idea.
            return (1 << (sqr * 4));
        }
        static int Conversion(string input)
        {            
            int count = input.Length - 1; 
            int digit;
            int inDecimal = 0;

            for (int i = 0; i < input.Length; i++)  
            {
                switch (input[i])
                {
                    case 'A':
                        digit = 10; 
                        break;
                    case 'B':
                        digit = 11; 
                        break;
                    case 'C':
                        digit = 12;
                        break;
                    case 'D':
                        digit = 13;
                        break;
                    case 'E':
                        digit = 14;
                        break;
                    case 'F':
                        digit = 15; 
                        break;
                    default: 
                        digit = int.Parse(Convert.ToString(input[i])); 
                        break;
                }

                inDecimal = inDecimal + digit * Pow(count);
                count--;
            }
            return inDecimal;
        }
        static void Main()
        {
            Console.Write("Enter number in Hex(without 0x): ");
            string input = Console.ReadLine().ToUpper();
            int decimalResult = Conversion(input);
            Console.WriteLine("The number in decimal is: "+decimalResult);
        }
    }

