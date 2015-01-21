using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
*/

class ExpressiomBrackets
{
     static void BracketsCheck(out int openningBrackets, out int closingBrackets)
    {
        openningBrackets = 0;
        closingBrackets = 0;
        string inputedExpression = Console.ReadLine();

        for (int i = 0; i < inputedExpression.Length - 1; i++)
        {
            if (inputedExpression[i] == '(')
            {
                openningBrackets++;
                for (int j = i; j < inputedExpression.Length; j++)
                {
                    if (inputedExpression[j] == ')')
                    {
                        closingBrackets++;
                    }
                }
            }
        }
    }
    static void Main()
    {
        Console.Write("Enter the expression:");
        int openningBrackets;
        int closingBrackets;
        BracketsCheck(out openningBrackets, out closingBrackets);
        if (openningBrackets == closingBrackets)
        {
            Console.WriteLine("The brackets are wrong");
        }
        else
        {
            Console.WriteLine("The brackets are as they should be");
        }
    }

    
}

