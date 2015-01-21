using System;

//nice idea, but no time left
class Logo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int z = (x/2) + 1; 
        int y = x;
        int width = ((z + z) +(y + y)) - 3;
        int height = (x + x + x) - 2;
        int[,] matrix = new int [width,height];

        int curRow = x / 2;
        int curCol = 0;

        while (true)
        {
            matrix[curRow, curCol] = 1;

            curCol++;
            curRow--;
            if (curRow<0)
            {
                curCol--;
                curRow++;
                break;
            }
        }
        while (true)
        {
            matrix[curRow, curCol] = 1;

            curRow++;
            curCol--;

            if (curCol == x)
            {
                break;
            }
        }

         
        
        for (int row = 0; row < width; row++)
        {
            for (int coll = 0; coll < height; coll++)
            {
                if (matrix[row, coll] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row,coll]==1)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
       // Console.WriteLine();
    }
}

