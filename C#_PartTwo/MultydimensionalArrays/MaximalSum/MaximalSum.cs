using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a program that reads a rectangular matrix of size N x M
 * and finds in it the square 3 x 3 that has maximal sum of its elements.
 */
namespace MaximalSum
{
    class MaximalSum
    {
        static void Printing(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write("|");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}|", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static int[,] Hardcoded()
        {
            int[,] matrix = {
                                {5, -2, 4, 6, 8},
                                {7, 9, 4, 3, 7},
                                {11, 5, 7, 4, 3},
                                {4, 6, 3, -12, 3}            
                            };
            return matrix;
        }
        static int[,] UserInputed(int[,] matrix)
        {
            //Console.WriteLine("So you choose to enter it manually, well start:");
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {   
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("Enter: matrix[{0},{1}]: ",row, col);
                    
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return matrix;
        }

        static int[,] CalculatingMaxSum(int[,] matrix)
        {
            int biggerSum = int.MinValue;
            int rows = -1;
            int cols = -1;
            
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    
                    //Yes it's ugly, the other way was with four, for cycles and got me a little confused.

                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +     
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + 
                        matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > biggerSum) 
                    {
                        biggerSum = sum;
                        rows = row;
                        cols = col;
                    }
                    sum = int.MinValue;
                }
            }
            Console.WriteLine("The biggest sum is: " + biggerSum);
            Console.WriteLine("It starts on row: {0} and coll: {1} ", rows, cols);
            return matrix;
           
        }

        static void Choices()
        {
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("This is hardcoded matrix, that I've made, so you won't have to input everything: ");
                Printing(Hardcoded());
                Console.WriteLine();
                int[,] optionOne = new int[4, 5];
                optionOne = CalculatingMaxSum(Hardcoded());

            }

            if (choice == 2)
            {
                Console.WriteLine("So you've decided to test it, ok");

                Console.Write("Input, rows: ");
                int height = int.Parse(Console.ReadLine());

                Console.Write("Input, colls: ");
                int width = int.Parse(Console.ReadLine());

                int[,] optionTwo = new int[height, width];
                optionTwo = UserInputed(optionTwo);

                Console.WriteLine("This is what you've just typed");
                Printing(optionTwo);
                Console.WriteLine();
                CalculatingMaxSum(optionTwo);

            }
        }
        static void Main()
        {
            Console.WriteLine("Now You have 2 choices:\nSee hardcoded matrix: 1\nInput your Own: 2");
            Choices();
            
        
        }

        
    }
}
