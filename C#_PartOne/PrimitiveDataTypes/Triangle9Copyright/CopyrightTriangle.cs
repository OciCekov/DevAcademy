﻿using System;
using System.Text;

/*Write a program that prints an isosceles triangle of 9 copyright symbols ©.
 * Use Windows Character Map to find the Unicode code of the © symbol.
 * Note: the © symbol may be displayed incorrectly.
 */

class CopyrightTriangle
{
    static void Main()
    {
        char symbol = '\u00A9'; 
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("{0}", symbol);
        Console.WriteLine("{0}{0}",symbol);
        Console.WriteLine("{0}{0}{0}", symbol);
        Console.WriteLine("{0}{0}", symbol);
        Console.WriteLine("{0}", symbol);
    }
}
