using System;

/*Declare  two integer variables and assign them with 5 and 10
 * and after that exchange their values.
 */

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Original values \"a={0}, b={1}\"",a ,b);
        a = a ^ b;
        b = b ^ a;
        a = a ^ b; 
        Console.WriteLine("New values \"a={0}, b={1}\"", a, b );
        Console.WriteLine("Don't believe me? Give it a try.");
        Console.Write("Eneter a: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int d = int.Parse(Console.ReadLine());
        c = c ^ d;
        d = d ^ c;
        c = c ^ d;
        Console.WriteLine("Result of your numbers: \"a={0}, b={1}\"", c, d);
    }
}

