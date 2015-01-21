using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//        Example: The target substring is "in". The text is as follows:
//        We are living in an yellow submarine. 
//        We don't have anything else. Inside the submarine is very tight. 
//        So we are drinking all the day.
//        We will move out of it in 5 days.


//    The result is: 9.

class RepeatingSubstring
{
    static void Main()
    {
        string input = " We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int repeatCounter = 0;
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input.Substring(i, 2).ToLower() == "in")
            {
                repeatCounter++;
            }
        }
        Console.WriteLine(repeatCounter);
    }
}

