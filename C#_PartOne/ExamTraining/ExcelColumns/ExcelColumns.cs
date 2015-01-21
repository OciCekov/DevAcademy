using System;


class ExcelColumns

{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        long letters = 26, sum = 0;
        for (long i = 1; i <= input; i++)
        {
            char symb3 = char.Parse(Console.ReadLine());
            sum = sum + ((symb3 - (long)64) * (long)Math.Pow(letters, (input - i)));
        }
        Console.WriteLine(sum);
    }
}