using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThunderBird
{
    class Matchu
    {
        static void Main(string[] args)
        {
            //Preparing console
            int width = 80;
            int height = 50;
            Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetWindowSize(width, height);
            FrontPage.WellcomeScreen(width, height);
            int size = 0;
            Console.ResetColor();

            // Infinite loop, toggles main menu on key press, 
            do
            {
                // Assigning value to "MenuScreenChoice", depending on it's value a menu is displayed  
                int menuScreenChoice = FrontPage.MenuMovement();

                // Difficulty level option
                if (menuScreenChoice == 1)
                {
                    int difficultyChoice = FrontPage.PlayScreenMovement();
                    switch (difficultyChoice)
                    {
                        case 1: size = 4; Console.Clear(); break;
                        case 2: size = 6; Console.Clear(); break;
                        case 3: size = 8; Console.Clear(); break;
                    }
                    Console.ResetColor();
                    break;
                }

                // Options, sound on/off option 
                else if (menuScreenChoice == 2)
                {
                    FrontPage.OptionsMovement();
                    menuScreenChoice = 0;
                    continue;
                }

                // How to play options
                else if (menuScreenChoice == 3)
                {
                    Console.Clear();
                    try
                    {
                        ConsoleKey button;
                        StreamReader rules = new StreamReader(@"..\..\RulesAndControls.txt");
                        string reader = rules.ReadToEnd();
                        Console.Clear();
                        Console.WriteLine(reader);
                        button = Console.ReadKey(true).Key;
                        menuScreenChoice = 0;
                        Console.Clear();
                        continue;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Can't access the file" + ex.GetType().Name);
                    }
                }
                // Exit choice
                else if (menuScreenChoice == 4)
                {
                    return;
                }
            } while (true);
            // menu end

            //Creating game field 
            int sybCount = (size * size / 2);
            char[] symbols = new char[sybCount];
            try
            {
                StreamReader reader1 = new StreamReader(@"..\..\symbols.txt");
                using (reader1)
                {
                    for (int i = 0; i < sybCount; i++)
                    {
                        symbols[i] = (char)reader1.Read();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileLoadException("Can't access the input file!");
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("File could not be found in the current directory");
            }

            //User details entry
            string name = " ";
            do
            {
                Console.Clear();
                Console.WriteLine(new string('_', 79));
                Console.WriteLine();
                Console.WriteLine("Username: ");
                Console.WriteLine(new string('_', 79));
                if (name == "")
                {
                    Console.WriteLine("\nPlease, enter username!");
                    Console.WriteLine(new string('_', 79));
                }
                Console.SetCursorPosition(10, 2);
                name = Console.ReadLine();
            } while (name == "");

            Console.Clear();
            Player player = new Player(name, size);
            Field newGame = new Field(size, symbols);
            newGame.Shuffle();
            newGame.DisplayField(size);
            newGame.GameEngine(size);
            player.SetPlayerScore(newGame.moves, newGame.time.Minutes, newGame.time.Seconds);
            player.DisplayScore();
            player.SaveScore();
            player.DisplayHighScores();
        }
        public static bool sound { get; set; }
    }
}
