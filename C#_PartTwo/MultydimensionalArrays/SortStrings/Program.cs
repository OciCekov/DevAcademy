using System;

class StringSort
{  

    static void Main()
    {
        string[] array = { "asxz", "sdfdss", "assdfsdfffxz", "ax", "asz", "asxasz", "jszxz" };
        
        int length = array.Length;
        int[] howLong = new int[length];

        for (int i = 0; i < length; i++)
        {
            howLong[i] = array[i].Length;
        }

        Array.Sort(howLong, array);

        for (int index = 0; index < length; index++)
        {
            Console.WriteLine(array[index]);
        }
    }
}
