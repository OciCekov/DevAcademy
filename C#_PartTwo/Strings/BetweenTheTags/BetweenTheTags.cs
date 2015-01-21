using System;
/* You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
 * The tags cannot be nested. Example:
 * Input:  We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
 * Result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/
class BetweenTheTags
{
    static void Main()
    {
        string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        int start = 0;
        while (start > -1)
        {
            int startIndex = input.IndexOf("<upcase>", start);
            if (startIndex == -1)
            {
                break;
            }
            
            int closingIndex = input.IndexOf("</upcase>", startIndex + 8);
            if (closingIndex == -1)
            {
                break;
            }
            string inTheMiddle = input.Substring(startIndex + 8, closingIndex - startIndex - 8);
            input = input.Replace(inTheMiddle, inTheMiddle.ToUpper());
            start = closingIndex + 9;
        }
        input = input.Replace("<upcase>", "");
        input = input.Replace("</upcase>", "");
        Console.WriteLine(input);

    }
}

