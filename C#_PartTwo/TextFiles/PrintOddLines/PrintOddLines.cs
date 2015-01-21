using System;
using System.IO;

/* 01.Write a program that reads a text file and prints on the console its odd lines.
*/
class PrintOddLines
{
    static void WholeFile()
    {
        //This was made just for "Getting the joke" pourpose 
        Console.WriteLine("This is whole text file");
        Console.WriteLine();
        var wholeFile = new StreamReader(@"..\..\FirstExcersize.txt");
        
        Console.WriteLine(wholeFile.ReadToEnd());
        Console.WriteLine();
    }
    static void Main()
    {
        // Used Var just to skip writing StreamReader twice. 
        var reader = new StreamReader(@"..\..\FirstExcersize.txt");
        string readLine = reader.ReadLine();
        int counter = 1;
        WholeFile();
        Console.WriteLine("This is just the alltered file");
        Console.WriteLine();
        while (readLine !=null)
        {
            Console.WriteLine("Line{0} = {1}", counter, readLine);
            counter += 2;
            readLine = reader.ReadLine();
        }
    }
}

