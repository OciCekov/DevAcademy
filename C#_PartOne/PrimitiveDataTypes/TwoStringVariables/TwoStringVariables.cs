using System;

/*Declare two string variables and assign them with “Hello” and “World”.
 * Declare an object variable and assign it with the concatenation of the first two variables
 * (mind adding an interval). Declare a third string variable and initialize it with the value
 * of the object variable (you should perform type casting).
 */

class TwoStringVariables
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object both = first + " " + second;
        string allOfthem = (string)both;
        Console.WriteLine(allOfthem + "!");
    }
}

