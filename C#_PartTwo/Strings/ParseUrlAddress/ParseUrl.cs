using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Write a program that parses an URL address given in the format:
		and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php t
        he following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
 */ 

class ParseUrl
{
    static void Main()
    {
        Console.Write("Enter the URL: ");
        string input = Console.ReadLine();
        string[] splitChars = new string[] {"://", "/"};
        string[] splitted = input.Split(splitChars,3,StringSplitOptions.None);
        splitted[2] += splitted[2];
        Console.WriteLine("protocol: {0}\nserver: {1}\nresource: {2}", splitted[0], splitted[1], splitted[2]);

     
        
    }
}

