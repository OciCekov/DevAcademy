using System;
using System.IO;

/*Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
 * Assume the files have equal number of lines.
*/
class CompareTextFiles
{
    static void Main()
    {
        using (StreamReader firstFile = new StreamReader(@"..\..\FirstFile.txt"), secondFile = new StreamReader(@"..\..\SecondFile.txt"))
        {
            int sameLines = 0;
            int differentLines = 0;
            string linesInFirst;
            string linesInSecond;
            while ((linesInFirst = firstFile.ReadLine()) != null && (linesInSecond = secondFile.ReadLine()) != null)
            {
                if (linesInFirst == linesInSecond)
                {
                    sameLines++;
                }
                else
                {
                    differentLines++;
                }
            }
            Console.WriteLine("There are {0} same lines and {1} different lines", sameLines, differentLines);
        }
    }
}

