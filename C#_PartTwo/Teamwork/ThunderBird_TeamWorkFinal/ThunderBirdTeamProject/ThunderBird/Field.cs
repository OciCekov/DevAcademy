using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThunderBird
{
    
    class Field
    {

        bool soundCheck = true;
        private int dimension;
        char[] symbs;
        char[,] board;
        private Cell[,] cells = new Cell[0, 0];
        private bool[,] hitCells = new bool[0, 0];
        private int cellCount = 0;
        private int successRate = 0;
        private Stopwatch stopwatch = new Stopwatch();
        public int moves = 0;
        public TimeSpan time = new TimeSpan();

        public int Dimension
        {
            get { return this.dimension; }
           private set { this.dimension = value; }
        }

        /// <summary>
        /// Creates field with the coresponding size and fill it with objects of type Cell
        /// </summary>
        /// <param name="Dimension">Number, setting field size</param>
        /// <param name="symbs">Char array with symbols</param>
        public Field(int Dimension, char[] symbs)
        {
            this.dimension = Dimension;
            this.board = new char[Dimension, Dimension];
            this.symbs = symbs;
            cells = new Cell[Dimension, Dimension];
            hitCells = new bool[Dimension, Dimension];
            for (int l = 0; l < Dimension; l++)
            {
                for (int u = 0; u < Dimension; u++)
                {
                    cells[l, u] = new Cell(l, u);
                }
            }
        }
       
        /// <summary>
        /// Shuffle symbols in the matrix
        /// </summary>
        public void Shuffle()
        {
            double dimm = Math.Sqrt(this.board.Length);
            Random randX = new Random();
            Random randY = new Random();
            int x = 0;
            int y = 0;
            bool success;
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < symbs.Length; k++)
                {
                    success = false;
                    do
                    {
                        x = randX.Next(0, (int)dimm);
                        y = randX.Next(0, (int)dimm);
                        if (this.cells[x, y].Inner == '\0')
                        {
                            this.cells[x, y].setSymbol(symbs[k]);
                            success = true;
                        }
                    } while (!success);
                }
            }
        }

        /// <summary>
        /// Displays all the cards (backs) for the choosen level
        /// </summary>
        /// <param name="size">Number for field size</param>
        /// <param name="left">Number for field coordinate X</param>
        /// <param name="top">Number for field coordinate Y</param>
        public void DisplayField(int size, int left = 0, int top = 0)
        {
            for (int z = 0; z < size; z++)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j);
                        Console.WriteLine("{0}{0}{0}{0}{0} ", (char)0x2591);
                    }
                    Console.WriteLine();
                    top++;
                }
                top = 0;
                left++;
            }
        }

        /// <summary>
        /// Call a method to display an opened cell
        /// </summary>
        /// <param name="userInpX">Int pointing at array position X</param>
        /// <param name="userInpY">Int pointing at array position Y</param>
        public void DisplayOneCell(int userInpX, int userInpY)
        {
            cells[userInpX, userInpY].DisplayCell(cells[userInpX, userInpY].PosX, cells[userInpX, userInpY].PosY);
        }

        /// <summary>
        ///  Call a method to display an opened cell colored - when the cursor is over it
        /// </summary>
        /// <param name="userInpX">Int pointing at array position X</param>
        /// <param name="userInpY">Int pointing at array position Y</param>
        public void DisplayOneCellPainted(int userInpX, int userInpY)
        {
            cells[userInpX, userInpY].DisplayCellPainted(cells[userInpX, userInpY].PosX, cells[userInpX, userInpY].PosY);
        }
               
        /// <summary>
        /// Re-displays a card back when the cursor moves out of it
        /// </summary>
        /// <param name="left">Number - block coordinate X</param>
        /// <param name="top">Number - block coordinate Y</param>
        public void oneBlockDraw(int left, int top)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j);
                Console.WriteLine("{0}{0}{0}{0}{0} ", (char)0x2591);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Re-displays a card back when the cursor is over it
        /// </summary>
        /// <param name="left">Number - block coordinate X</param>
        /// <param name="top">Number - block coordinate Y</param>
        public void coloredBlockDraw(int left, int top)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}{0}{0}{0}{0}", (char)0x2591);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
            }
        }

        /// <summary>
        /// Compares two opened cells if they are a pair or not
        /// </summary>
        /// <param name="lastOpenedRow">Int that contains Col for previous opened cell</param>
        /// <param name="lastOpenedCol">Int that contains Row for previous opened cell</param>
        /// <param name="rowIndex">Int that contains Row for current opened cell</param>
        /// <param name="colIndex">Int that contains Col for current opened cell</param>
        /// <returns></returns>
        public int CellsCompare(int lastOpenedRow, int lastOpenedCol, int rowIndex, int colIndex)
        {
            cellCount = 0;
            if (cells[lastOpenedRow, lastOpenedCol].Inner == cells[rowIndex, colIndex].Inner)
            {
                hitCells[lastOpenedRow, lastOpenedCol] = true;
                hitCells[rowIndex, colIndex] = true;
                lastOpenedRow = 0;
                lastOpenedCol = 0;
                rowIndex = 0;
                colIndex = 0;
                successRate += 2;
            }
            else
            {
                Thread.Sleep(1000);
                oneBlockDraw(lastOpenedRow, lastOpenedCol);
                oneBlockDraw(rowIndex, colIndex);
                hitCells[lastOpenedRow, lastOpenedCol] = false;
                lastOpenedRow = 0;
                lastOpenedCol = 0;
                coloredBlockDraw(rowIndex, colIndex);
            }
            return successRate;
        }

        /// <summary>
        /// Watch the cursor and react to a button usage
        /// </summary>
        /// <param name="size">Numer that sets field size</param>
        public void GameEngine(int size)
        {

            int rowIndex = 0;
            int colIndex = 0;
            int lastRowIndex = 0;
            int lastColIndex = 0;
            int lastOpenedRow = 0;
            int lastOpenedCol = 0;
            bool isGameOver = false;
            ConsoleKey key;
            do
            {
                stopwatch.Start();
                if (cellCount == 1)
                {
                    DisplayOneCell(lastOpenedRow, lastOpenedCol);
                }

                for (int k = 0; k < dimension; k++)
                {
                    for (int l = 0; l < dimension; l++)
                    {
                        if (hitCells[k, l] == true)
                        {
                            if (rowIndex == k && colIndex == l)
                            {
                                DisplayOneCellPainted(k, l);
                            }
                            else
                            {
                                DisplayOneCell(k, l);
                            }
                        }
                    }
                }

                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                {
                    break;
                }

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        rowIndex--;
                        if (rowIndex < 0)
                        {
                            rowIndex = 0;
                            if (FrontPage.CheckSound(soundCheck))
                            {
                                Console.Beep();
                            }                            
                            break;
                        }
                        oneBlockDraw(lastRowIndex, lastColIndex);
                        coloredBlockDraw(rowIndex, colIndex);
                        lastRowIndex = rowIndex;
                        lastColIndex = colIndex;
                        break;

                    case ConsoleKey.RightArrow:
                        rowIndex++;
                        if (rowIndex > size - 1)
                        {
                            rowIndex = size - 1;
                            if (FrontPage.CheckSound(soundCheck))
                            {
                                Console.Beep();
                            }   
                            break;
                        }
                        oneBlockDraw(lastRowIndex, lastColIndex);
                        coloredBlockDraw(rowIndex, colIndex);
                        lastRowIndex = rowIndex;
                        lastColIndex = colIndex;
                        break;

                    case ConsoleKey.UpArrow:
                        colIndex--;
                        if (colIndex < 0)
                        {
                            colIndex = 0;
                            if (FrontPage.CheckSound(soundCheck))
                            {
                                Console.Beep();
                            }   
                            break;
                        }

                        oneBlockDraw(lastRowIndex, lastColIndex);
                        coloredBlockDraw(rowIndex, colIndex);
                        lastRowIndex = rowIndex;
                        lastColIndex = colIndex;
                        break;

                    case ConsoleKey.DownArrow:
                        colIndex++;
                        if (colIndex > size - 1)
                        {
                            colIndex = size - 1;
                            if (FrontPage.CheckSound(soundCheck))
                            {
                                Console.Beep();
                            }   
                            break;
                        }

                        oneBlockDraw(lastRowIndex, lastColIndex);
                        coloredBlockDraw(rowIndex, colIndex);
                     
                        lastRowIndex = rowIndex;
                        lastColIndex = colIndex;
                        break;
                    case ConsoleKey.Enter:
                        {
                            if (hitCells[rowIndex, colIndex] != true)
                            {
                                DisplayOneCell(rowIndex, colIndex);
                                cellCount++;
                                if (cellCount == 1)
                                {

                                    lastOpenedRow = rowIndex;
                                    lastOpenedCol = colIndex;
                                    hitCells[lastOpenedRow, lastOpenedCol] = true;                                    
                                }
                                else if (cellCount == 2)
                                {
                                    if ((lastOpenedRow == rowIndex) && (lastOpenedCol == colIndex))
                                    {
                                        if (FrontPage.CheckSound(soundCheck))
                                        {
                                            Console.Beep();
                                        }   
                                        cellCount = 1;
                                    }
                                    else
                                    {
                                        moves++;
                                        int isEnd = CellsCompare(lastOpenedRow, lastOpenedCol, rowIndex, colIndex);
                                        cellCount = 0;
                                        if (isEnd == Dimension * Dimension)
                                        {
                                            isGameOver = true;
                                            stopwatch.Stop();
                                            time = stopwatch.Elapsed;
                                            Console.SetCursorPosition(0, (size * 5) + 1);
                                       
                                            using (StreamReader winMessage = new StreamReader(@"..\..\WinMessage.txt"))
                                            {
                                                Console.WriteLine(winMessage.ReadToEnd());
                                            }

                                            if (FrontPage.CheckSound(soundCheck))
                                            { 
                                                Music();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    default: key = Console.ReadKey(true).Key; break;
                }

            } while (isGameOver == false);
        }

        /// <summary>
        /// Contains the music for the end of the game
        /// </summary>
        private static void Music()
        {
            Console.Beep(659, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(375);
            Console.Beep(392, 125);
            Thread.Sleep(375);
        }
    }
}
