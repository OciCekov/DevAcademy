using System;



class FillingInDifferentWays
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

    static int[,] TopToBottom(int[,] matrix)
    {
        int filler = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = filler;
                filler++;
            }
        }
        return matrix;
    }

    static int[,] UpAndDown(int[,] matrix)
    {
        int filler = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = filler;
                    filler++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = filler;
                    filler++;
                }
            }
        }
        return matrix;
    }

    static int[,] Diagonal(int[,] matrix)
    {
        int filler = 1;
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int i = row, col = 0; i < matrix.GetLength(0); i++, col++)
            {
                matrix[i, col] = filler;
                filler++;
            }
        }
        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            for (int i = col, row = 0; i < matrix.GetLength(0); i++, row++)
            {
                matrix[row, i] = filler;
                filler++;
            }
        }
        return matrix;
    }

    static void UserChoice(int dimensions)
    {
        
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (choice == 1)
        {
            int[,] optionOne = new int[dimensions, dimensions];
            optionOne = TopToBottom(optionOne);
            Printing(optionOne);
        }
        else if (choice == 2)
        {
            int[,] optionTwo = new int[dimensions, dimensions];
            optionTwo = UpAndDown(optionTwo);
            Printing(optionTwo);
        }
        else if (choice == 3)
        {
            int[,] optionThree = new int[dimensions, dimensions];
            optionThree = Diagonal(optionThree);
            Printing(optionThree);
        }

        else
        {
            Console.WriteLine("Whoops! The thingy expirienced a problem and needs to close.");
        }
    }
    static void Main()
    {
        Console.Write("Enter how big this thing should be: ");
        int dimensions = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Now enter which one do you want to see:\n1: Top to bottom \n2: Up and down\n3: Diagonal");
        UserChoice(dimensions);
    }

   
}

