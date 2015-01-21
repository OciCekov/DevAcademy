using System;
using System.IO;
using System.Text.RegularExpressions;
/*Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
 * Ensure it will work with large files (e.g. 100 MB).
*/

class ReplaceStart
{
    static void Main()
    {
        var unmodified = new StreamReader(@"..\..\StartInput.txt");
        using (unmodified)
        {
            string readline = unmodified.ReadLine();
            var modified = new StreamWriter(@"..\..\StartOutput.txt");
            using (modified)
            {
                while (readline != null)
                {
                    string replace = readline.Replace("start", "finish");
                    readline = unmodified.ReadLine();
                    modified.WriteLine(replace);
                }
            }
        }
    }
}

