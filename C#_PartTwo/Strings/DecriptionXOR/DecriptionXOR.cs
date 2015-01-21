using System;
using System.Text;
/* Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters.
 * The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
 * the second – with the second, etc. When the last key character is reached, the next is the first.
*/
class DecriptionXOR

{
    static void Main()
    {
        Console.Write("Enter the sentance that you want to play with: ");
        string input = Console.ReadLine();
        Console.Write("Enter a key: ");
        string key = Console.ReadLine();

        string encrypted = EncoderDecoder(input, key);
        Console.WriteLine(encrypted);

        string decrypted = EncoderDecoder(encrypted, key);
        Console.WriteLine(decrypted);
    }

    static string EncoderDecoder(string input, string key)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < input.Length; i += key.Length)
        {
            for (int j = 0; j < key.Length; j++)
            {
                if (i + j > input.Length - 1)
                {
                    break;
                }
                char temp = (char)(input[i + j] ^ key[j]);
                sb.Append(temp);
            }
        }
        return sb.ToString();
    }
}