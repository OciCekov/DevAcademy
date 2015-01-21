namespace BitArray
{
    using System;
    public class BitArrayMain
    {
        static void Main()
        {

            int num = 8765;
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(64, '0'));


            ulong number = 8765;
            var bits = new BitArray(number);



            foreach (var bit in bits)
            {
                Console.Write(bit);
            }
            Console.WriteLine();


            var bits2 = new BitArray((ulong)8766);
            Console.WriteLine(bits.Equals(bits2));

            Console.WriteLine(bits == bits2);

            Console.WriteLine(bits != bits2);
            Console.WriteLine();


            Console.WriteLine(bits);

            Console.WriteLine(bits[0]);
        }
    }
}
