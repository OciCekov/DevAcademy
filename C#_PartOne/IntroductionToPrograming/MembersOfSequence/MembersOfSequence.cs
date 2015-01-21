using System;

// Write a program that prints the first 10 numbers of the sequence :2, -3, 4, -5, 6, -7.....
class MembersOfSequence
{
    static void Main()
    {
        int even = 2; 
        int odd = -3;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(even);
            even += 2;
            Console.WriteLine(odd);
            odd += -2;
        }
    }
}

