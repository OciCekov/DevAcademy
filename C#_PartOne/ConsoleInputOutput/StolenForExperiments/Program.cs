namespace CalcWithAccuracy
{
    using System;

    class CalcWithAccuracy
    {
        static void Main(string[] args)
        {
            /*Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...*/

            float sum = 1f;
            int counter = 2;

            while (1f / counter > 0.001)
            {
                if (counter % 2 == 0)
                {
                    sum += 1f / counter;
                }
                else
                {
                    sum -= 1f / counter;
                }
                counter++;
            }

            Console.WriteLine("The sum is {0:0.000}", sum);
        }
    }
}