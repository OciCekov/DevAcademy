using System;

/*Which of the following values can be assigned to a variable of type float and which to a variable of type double:
 *34.567839023, 12.345, 8923.1234857, 3456.091?
 */

class WhichIsFloatDouble
{
    static void Main()
    {
        double num1 = 34.567839023d;
        float num2 = 12.345f;
        double num3 = 8923.1234857d;
        float num4 = 3456.091f;
        Console.WriteLine("Float numbers are {0} and {1}", num2, num4);
        Console.WriteLine("Double numbers are {0} and {1}", num1, num3);
    }
}

