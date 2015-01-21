using System;

/*Create a program that assigns null values to an integer and to double variables. 
 *Try to print them on the console, 
 *try to add some values or the null literal to them and see the result. 
 */

class AssignNull
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Here is integer(in quotes)\"{0}\" and here should be double(in quotes) \"{1}\"",nullInt, nullDouble);
        nullInt = 25;
        nullDouble = 25.5;
        Console.WriteLine("And thats after adding 25 and 25.5 to double");
        Console.Write("This is integer: {0}\n", nullInt);
        Console.WriteLine("This is double: {0}", nullDouble);
    }
}

