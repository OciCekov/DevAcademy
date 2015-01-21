using System;
/*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/
class ShortBinaryReresentation
{

    static string binaryRepres = "";

    static void ConvertToBinary(int number)
    {
        for (int i = 0; i <= 15; i++)
        {
            if (number % 2 == 0)
            {
                binaryRepres = "0" + binaryRepres;
            }
            else
            {
                binaryRepres = "1" + binaryRepres;
            }
            number /= 2;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        short number = short.Parse(Console.ReadLine());
        if (number >= 0)
        {
            ConvertToBinary(number);
            Console.WriteLine(binaryRepres);
        }
        else
        {
            ConvertToBinary(65536 + number);
            Console.WriteLine(binaryRepres);
        }
    }
}