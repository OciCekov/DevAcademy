using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderBird
{

    class Cell
    {
        private int posX;

        private int posY;
        private char inner;

        public int PosX
        {
            get { return this.posX; }
            private set { this.posX = value; }
        }
        public int PosY
        {
            get { return this.posY; }
            private set { this.posY = value; }
        }
        public char Inner
        {
            get { return this.inner; }
            private set { this.inner = value; }
        }
        public Cell(int posX, int posY)
        {
            this.PosX = posX;
            this.PosY = posY;
        }

        /// <summary>
        /// Displays opened card with the corresponding coordinates
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public void DisplayCell(int left, int top)
        {
            char symbol = this.inner;
            int j = 0;
            
            switch (symbol)
            {
                case '1': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" *** "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("** **"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("** **"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" *** "); j++;
                    break;
                case '2': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("!!!!!"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" !!! "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" !!! "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("!!!!!"); j++;
                    break;

                case '3': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" /// "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("// //"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("// //"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" /// "); j++;
                    break;
                case '4': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("♥♥♥♥♥"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ♥♥♥ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ♥♥♥ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("♥♥♥♥♥"); j++;
                    break;
                case '5': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ^^^ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("^^^^^"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("^^^^^"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ^^^ "); j++;
                    break;
                case '6': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("$$$$$"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" $$$ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" $$$ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("$$$$$"); j++;
                    break;
                case 'A': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <!> "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<> <>"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<> <>"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <!> "); j++;
                    break;
                case 'B': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("@@@@@"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" @@@ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" @@@ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("@@@@@"); j++;
                    break;
                case 'C': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" [+] "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("[] []"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("[] []"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" [+] "); j++;
                    break;
                case 'D': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("====="); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" === "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" === "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("====="); j++;
                    break;
                case 'E': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(@" /|\ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(@"/\ /\"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(@"\/ \/"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(@" \|/ "); j++;
                    break;
                case 'F': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" {*} "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("{} {}"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("{} {}"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" {*} "); j++;
                    break;
                case 'G': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("‡‡‡‡‡"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ‡‡‡ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ‡‡‡ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("‡‡‡‡‡"); j++;
                    break;
                case 'H': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" €€€ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("€€ €€"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("€€ €€"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" €€€ "); j++;
                    break;
                case 'I': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("•••••"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ••• "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ••• "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("•••••"); j++;
                    break;
                case 'J': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ¶¶¶ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("¶¶ ¶¶"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("¶¶ ¶¶"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ¶¶¶ "); j++;
                    break;
                case 'K': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("µµµµµ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" µµµ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" µµµ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("µµµµµ"); j++;
                    break;
                case 'L': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ¿¿? "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("¿? ¿?"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("¿? ¿?"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ¿?? "); j++;
                    break;
                case 'M': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("®®®®®"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ®®® "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ®®® "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("®®®®®"); j++;
                    break;
                case 'N': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ŒŒŒ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("ŒŒ ŒŒ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("ŒŒ ŒŒ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ŒŒŒ "); j++;
                    break;
                case 'O': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("#*#*#"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" #*# "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" #*# "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("#*#*#"); j++;
                    break;
                case 'P': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ΩΩΩ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("ΩΩ ΩΩ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("ΩΩ ΩΩ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ΩΩΩ "); j++;
                    break;
                case 'Q': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ||| "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("== =="); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("== =="); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ||| "); j++;
                    break;
                case 'R': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ()() "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("()**()"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("()**()"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ()() "); j++;
                    break;
                case 'S': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <><> "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<>==<>"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<>==<>"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <><> "); j++;
                    break;
                case 'T': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" №1№ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("№1 №1"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("№1 №1"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" №1№ "); j++;
                    break;
                case 'U': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<-><->"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <><> "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <><> "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<-><->"); j++;
                    break;
                case 'V': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" _!_ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("|| ||"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("|| ||"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" _!_ "); j++;
                    break;
                case 'W': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" C!Ɔ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("CƆ CƆ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("CƆ CƆ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" C!Ɔ "); j++;
                    break;
                case 'X': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" :-) "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(":) (:"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(":) (:"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" (-: "); j++;
                    break;
                case 'Y': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ~:~ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("~~ ~~"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("~~ ~~"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ~:~ "); j++;
                    break;
                case 'Z': Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("♠♠♠♠♠"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ♠♠♠ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ♠♠♠ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("♠♠♠♠♠"); j++;
                    break;
            }
            Console.WriteLine();

        }

        public void setSymbol(char symb)
        {
            this.Inner = symb;
        }

        /// <summary>
        ///  Displays an opened card colored with the corresponding coordinates
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public void DisplayCellPainted(int left, int top)
        {
            char symbol = this.inner;
            int j = 0;

            switch (symbol)
            {

                case '1': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" *** "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("** **"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("** **"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" *** "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case '2': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("!!!!!"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" !!! "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" !!! "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("!!!!!"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case '3': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" /// "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("// //"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("// //"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" /// "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case '4': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("♥♥♥♥♥"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ♥♥♥ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ♥♥♥ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("♥♥♥♥♥"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case '5': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ^^^ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("^^^^^"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("^^^^^"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ^^^ "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case '6': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("$$$$$"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" $$$ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" $$$ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("$$$$$"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'A': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <!> "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<> <>"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<> <>"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <!> "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'B': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("@@@@@"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" @@@ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" @@@ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("@@@@@"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'C': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" [+] "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("[] []"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("[] []"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" [+] "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'D': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("====="); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" === "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" === "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("====="); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'E': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(@" /|\ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(@"/\ /\"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(@"\/ \/"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(@" \|/ "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'F': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" {*} "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("{} {}"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("{} {}"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" {*} "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'G': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("‡‡‡‡‡"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ‡‡‡ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ‡‡‡ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("‡‡‡‡‡"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'H': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" €€€ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("€€ €€"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("€€ €€"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" €€€ "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'I': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("•••••"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ••• "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ••• "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("•••••"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'J': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ¶¶¶ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("¶¶ ¶¶"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("¶¶ ¶¶"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ¶¶¶ "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'K': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("µµµµµ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" µµµ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" µµµ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("µµµµµ"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'L': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ¿¿? "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("¿? ¿?"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("¿? ¿?"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ¿?? "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'M': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("®®®®®"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ®®® "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ®®® "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("®®®®®"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'N': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ŒŒŒ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("ŒŒ ŒŒ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("ŒŒ ŒŒ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ŒŒŒ "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'O': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("#*#*#"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" #*# "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" #*# "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("#*#*#"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'P': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ΩΩΩ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("ΩΩ ΩΩ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("ΩΩ ΩΩ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ΩΩΩ "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'Q': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ||| "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("== =="); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("== =="); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ||| "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'R': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ()() "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("()**()"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("()**()"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ()() "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'S': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <><> "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<>==<>"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<>==<>"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <><> "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'T': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" №1№ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("№1 №1"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("№1 №1"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" №1№ "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'U': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<-><->"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <><> "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" <><> "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("<-><->"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'V': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" _!_ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("|| ||"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("|| ||"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" _!_ "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'W': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" C!Ɔ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("CƆ CƆ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("CƆ CƆ"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" C!Ɔ "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'X': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" :-) "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(":) (:"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(":) (:"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" (-: "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'Y': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ~:~ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("~~ ~~"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("~~ ~~"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ~:~ "); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 'Z': Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("♠♠♠♠♠"); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ♠♠♠ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine(" ♠♠♠ "); j++;
                    Console.SetCursorPosition(left + (left * 6), top + (top * 4) + j); Console.WriteLine("♠♠♠♠♠"); j++;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }

            Console.WriteLine();
        }
    }
}
