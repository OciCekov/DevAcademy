using System;
using System.IO;

namespace SortTheTextFile
{
    /*Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
	Ivan			George
	Peter		->	Ivan
	Maria			Maria
	George			Peter
     * 
    Pesho
    George
    Mara
    Pena
    Dimitur -> This is the sample input.
    Qvor
    Angel
    */
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Procedure start");
            var inputetText = new StreamReader(@"..\..\UnsortedInput.txt");
            using (inputetText)
            {
               
               string[] names = inputetText.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
               Array.Sort(names);
               var sortedOutput = new StreamWriter(@"..\..\SortedOutput.txt");
               using (sortedOutput)
               {
                   foreach (var name in names)
                   {
                       sortedOutput.WriteLine(name);
                   }
               }
            }
            Console.WriteLine("And it's over, you can get to the file destination");
        }
    }
}
