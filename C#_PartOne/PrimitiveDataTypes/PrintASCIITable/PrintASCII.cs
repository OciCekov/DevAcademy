using System;
using System.Text;

/*Find online more information about ASCII (American Standard Code for Information Interchange)
 * and write a program that prints the entire ASCII table of characters on the console.
 */

class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("So, this small thing:");
        for (int table = 0; table < 255; table++)
        {
            char symbols = (char) table;
            Console.WriteLine("{0} {1}", table, symbols);
        }
    }
}

