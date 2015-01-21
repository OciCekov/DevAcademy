using System;
using System.IO;

/* Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.
*/
class InsertLineNumbers
{
    static void Main()
    {
        var readFirst = new StreamReader(@"..\..\ExcersizeThree.txt");
        
        using (readFirst)
        {
            var writeSecond = new StreamWriter(@"..\..\Lined.txt");

            string readline = readFirst.ReadLine();
            int lineCount = 1;

            using (writeSecond)
            {
                while (readline != null)
                {
                    writeSecond.Write("line{0}: ", lineCount);
                    writeSecond.WriteLine(readline);
                    lineCount++;
                    readline = readFirst.ReadLine();
                }
            }
        }

    }
}

