using System;

/* Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
 * The cards should be printed with their English names. Use nested for loops and switch-case.
 */


class DeckOfCards
{
    static void Main()
    {
        string[] numbers = new string []{"Two" , "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
        
       

        for (int cardCount = 0; cardCount < numbers.Length; cardCount++ )
        {            
           
            for (int colourCount = 1;colourCount <= 4; colourCount++)
            {               
            
                switch (colourCount)
                {
                    case 1:
                        {
                            Console.WriteLine("{0} clubs", numbers[cardCount]);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("{0} spades", numbers[cardCount]);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("{0} diamonds", numbers[cardCount]);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("{0} hearts", numbers[cardCount]);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}

