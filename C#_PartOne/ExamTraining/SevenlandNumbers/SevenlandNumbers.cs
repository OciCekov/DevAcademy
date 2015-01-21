using System;



class SevenlandNumbers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int last = input % 10;
       

        if (input < 0)
        {
            input *= (-1);
        }

        else if (last == 6)
        {
            if (input % 100 == 66 && input % 1000 != 666 )
            {
                input += 34;
            }

            else if (input % 1000 == 666)
            {
                input += 334;
            }
            else 
            {
                input +=4;
            }
        }
        else if (true)
        {
            input += 1; 
        }
        Console.WriteLine(input);
    }
}

