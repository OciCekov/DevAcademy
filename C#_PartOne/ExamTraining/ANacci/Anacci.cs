using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANacci
{
    class Anacci
    {
        static void Main(string[] args)
        {

            int magic = 64;
            string firstInput = Console.ReadLine();
            int first = firstInput[0] - magic;

            string secondInput = Console.ReadLine();
            int second = secondInput[0] - magic;

            int lineCount = int.Parse(Console.ReadLine());
            int result = first + second;
            if (result > 26)
            {
                result = result % 26;
            }
            Console.WriteLine(firstInput);
            if (lineCount > 1)
            {



                string lastHope = ((char)(second + magic)).ToString() + ((char)(result + magic)).ToString();

                Console.WriteLine(lastHope);

                first = second;
                second = result;

                for (int i = 3; i <= lineCount; i++)
                {
                    result = first + second;
                    if (result > 26)
                    {
                        result = result % 26;
                    }
                    first = second;
                    second = result;
                    result = first + second;
                    if (result > 26)
                    {
                        result = result % 26;
                    }
                    first = second;
                    second = result;

                    Console.Write((char)(first + magic));
                    Console.Write(new String(' ', i - 2));
                    Console.WriteLine((char)(second + magic));

                }
            }
        }
    }
}
