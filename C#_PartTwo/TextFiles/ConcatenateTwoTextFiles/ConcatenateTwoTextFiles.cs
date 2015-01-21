using System;
using System.IO;

/*Write a program that concatenates two text files into another text file.
*/
class ConcatenateTwoTextFiles
{
    static void Main()
    {
        var concatenated = new StreamWriter(@"..\..\Concatenated.txt");
        
        using (concatenated)
        {
            Console.WriteLine("Reading first file...");
            var fileFirst = new StreamReader(@"..\..\First.txt");
            using (fileFirst)
            {
                string wholeFirst = fileFirst.ReadToEnd();
                concatenated.WriteLine(wholeFirst);

            }
            Console.WriteLine("Reading second file...");
            var FileSecond = new StreamReader(@"..\..\Second.txt");
            using (FileSecond)
            {
                string wholeSecond = FileSecond.ReadToEnd();
                concatenated.WriteLine(wholeSecond);
            }
            Console.WriteLine("All done...");
        }
    }
}

