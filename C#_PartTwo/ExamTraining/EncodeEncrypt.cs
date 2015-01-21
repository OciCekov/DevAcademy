using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EncodeEncrypt
{
    static string Encrypt(string message, string cypher)
    {
        string result = string.Empty;


        if (cypher.Length < message.Length)
        {
            result = EncryptWhenMessageIsLonger(message, cypher);
        }
        else
        {
            result = EcryptWhenCypherIsLonger(message, cypher);
        }

        return result;
    }

    static string EncryptWhenMessageIsLonger(string message, string cypher)
    {
        var result = new StringBuilder();

        int cypherPosition = 0;    // down in the for we can use "cypher = i % cypher.Lenght;" it's exactly the same as is with if 
        for (int i = 0; i < message.Length; i++)
        {
            char messageSymbol = message[i];
            char cypherSymbol = cypher[cypherPosition];
            char encrypted = EncrytSymbol(messageSymbol, cypherSymbol);

            result.Append(encrypted);

            cypherPosition++;
            if (cypherPosition == cypher.Length)
            {
                cypherPosition = 0;
            }
        }

        return result.ToString();
    }

    static string EcryptWhenCypherIsLonger(string message, string cypher)
    {
        var result = new StringBuilder(message);
        int messagePosition = 0;

       
        for (int i = 0; i < cypher.Length; i++)
        {
            char messageSymbol = result[messagePosition];
            char cypherSymbol = cypher[i];
            char encrypted = EncrytSymbol(messageSymbol, cypherSymbol);
            
            result[i] = encrypted;

            messagePosition++;
            if (messagePosition == message.Length)
            {
                messagePosition = 0;
            }
            
        }



        return result.ToString();
    }
    static char EncrytSymbol(char messageSymbol, char cypherSymbol)
    {
        int messageSymbolCode = messageSymbol - 'A';
        int cypherSymbolCode = cypherSymbol - 'A';

        int xoredSymbol = messageSymbolCode ^ cypherSymbolCode;

        char encrypted = (char)(xoredSymbol + 'A');



        return encrypted;
    }
    static string Encode(string text)
    {
        // This is really important and have to know.
        var result = new StringBuilder();
        char previosSymbol = text[0];
        int counter = 1;
        for (int i = 1; i < text.Length; i++)
        {



            if (text[i] == previosSymbol)
            {
                counter++;    
            }
            else
            {
                if (counter == 1 ) 
                {
                    result.Append(previosSymbol);
                }
                else if (counter == 2)
                {
                    result.Append(new string(previosSymbol, 2));
                }
                else
                {
                    result.Append(counter + previosSymbol.ToString());
                }
                counter = 1;
            }
            previosSymbol = text[i];
        }

        if (counter == 1)
        {
            result.Append(previosSymbol);
        }
        else if (counter == 2)
        {
            result.Append(new string(previosSymbol, 2));
        }
        else
        {
            result.Append(counter + previosSymbol.ToString());
        }
        counter = 1;

        // This is really important and have to know.
        return result.ToString();
    }

    static void Main()
    {
        string message = Console.ReadLine();
        string cypher = Console.ReadLine();

        string finalResult = Encode(Encrypt(message, cypher) + cypher) + cypher.Length;
        Console.WriteLine(finalResult);
    }
}

