using System;
using System.IO;

/* Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
 * The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file. Example:
 *     4
 *    
 * 2 3 3 4
 * 0 2 3 4			17
 * 3 7 1 2
 * 4 3 3 2
 * 
 * In the MatrixIn.txt is the example
 */
class BestSumInMatrix
{

    static int MaxOfTheMatrix(int[,] theMatrix)
    {
        int currentSum = 0;
        int bestSum = 0;

        for (int row = 0; row < theMatrix.GetLength(0) - 1; row++) 
        {
            for (int col = 0; col < theMatrix.GetLength(1) - 1; col++) 
            {
                currentSum = theMatrix[row, col] + theMatrix[row, col + 1] +
                             theMatrix[row + 1, col] + theMatrix[row + 1, col + 1];
                if (currentSum>bestSum)
                {
                    bestSum = currentSum;
                }
                currentSum = 0;
            }
        }
        return bestSum;
    }
    static void Main()
    {
        var matrixIn = new StreamReader(@"..\..\MatrixIn.txt.");
        var matrixOut = new StreamWriter(@"..\..\MatrixOut.txt");
        
        string line = "";
        string number = "";
        using (matrixIn)
        {
            line = matrixIn.ReadLine();
            int size = int.Parse(line);
            int[,] theMatrix = new int[size, size];
          //  char member;
            int row = 0;
            int coll = 0;
            while ((line = matrixIn.ReadLine()) !=null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] != ' ') 
                    {
                        number += line[i];
                    }
                    else
                    {
                        theMatrix[row, coll] = int.Parse(number);
                        number = "";
                        coll++;
                    }
                }
                theMatrix[row, coll] = int.Parse(number);
                coll = 0;
                row++;
                number = "";                
            }
            using (matrixOut)
            {
                matrixOut.WriteLine(MaxOfTheMatrix(theMatrix)); 
            }
        }
    }
}

