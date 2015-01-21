using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;


namespace ThunderBird
{
    
    class FrontPage
    {
        static bool sound = true;
        /// <summary>
        /// Displays difficulty choice options
        /// </summary>
        public static void PlayScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            var WholePlayscreen = new StreamReader(@"..\..\AfterPlay\WholeDifficulties.txt");
            Console.WriteLine(WholePlayscreen.ReadToEnd());
        }
        /// <summary>
        /// Тoggles difficulty options screen 
        /// </summary>
        /// <returns>value of choosen difficulty, 1 for easy, 2 for medium, 3 for hard</returns>
        public static int PlayScreenMovement()
        {
            int positionCounter = 0;

            ConsoleKey button;
            PlayScreen();
            do
            {
                button = Console.ReadKey(true).Key;
                Console.SetCursorPosition(0, 0);

                if (button == ConsoleKey.DownArrow)
                {
                    if (positionCounter == 3)
                    {
                        positionCounter = 1;
                    }
                    else
                    {

                    positionCounter++;
                    }
                }
                if (button == ConsoleKey.UpArrow)
                {
                    if (positionCounter == 1)
                    {
                        positionCounter = 3;
                    }
                    else
                    {
                        positionCounter--;
                    }
                }
                if (positionCounter == 1)
                {
                    PlayScreen();
                    Console.ResetColor();
                    Easy();
                    if (button == ConsoleKey.Enter)
                    {
                        Console.Clear();
                       
                        return 1;
                    }
                }
                if (positionCounter == 2)
                {
                    PlayScreen();
                    Console.ResetColor();
                    Medium();
                    if (button == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        return 2;
                    }
                }
                if (positionCounter == 3)
                {
                    PlayScreen();
                    Console.ResetColor();
                    Hard();
                    if (button == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        return 3;
                    }
                }
                if (positionCounter > 3)
                {
                    positionCounter = 0;
                }
                if (positionCounter < 0)
                {
                    positionCounter = 3;
                }

            } while (true);
        }
        /// <summary>
        /// Displays dificulty option easy
        /// </summary>
        public static void Easy()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Cyan;
            var easy = new StreamReader(@"..\..\AfterPlay\OnlyBaby.txt");
            Console.WriteLine(easy.ReadToEnd());
        }
        /// <summary>
        /// Displays dificulty option medium
        /// </summary>
        public static void Medium()
        {
            Console.SetCursorPosition(0, 12);
            Console.ForegroundColor = ConsoleColor.Cyan;
            var medium = new StreamReader(@"..\..\AfterPlay\OnlyNotHard.txt");
            Console.WriteLine(medium.ReadToEnd());
        }
        /// <summary>
        /// Displays dificulty option hard
        /// </summary>
        public static void Hard()
        {
            Console.SetCursorPosition(0, 22);
            Console.ForegroundColor = ConsoleColor.Cyan;
            var hard = new StreamReader(@"..\..\AfterPlay\OnlyYouCrazy.txt");
            Console.WriteLine(hard.ReadToEnd());
        }
        /// <summary>
        /// Toggles main menu options
        /// </summary>
        /// <returns>value for chosen option, 1 for play, 2 for options, 3 for how to play, 4 leave us</returns>
        public static int MenuMovement()
        {

            int downCounter = 0;
            Console.Clear();
           
            ConsoleKey button;
            MenuDisplay();
            do
            {
                button = Console.ReadKey(true).Key;
                Console.SetCursorPosition(0, 0);

                if (button == ConsoleKey.DownArrow)
                {
                    if (downCounter == 4)
                    {
                        downCounter = 1;
                    }
                    else
                    {
                    downCounter++;
                }
                }
                if (button == ConsoleKey.UpArrow)
                {
                    if (downCounter == 1)
                    {
                        downCounter = 4;
                    }
                    else
                    {
                    downCounter--;
                }
                }
                if (downCounter == 1)
                {
                    MenuDisplay();
                    Console.ResetColor();
                    Onlyplay();
                    if (button == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        return 1;
                    }
                }
                if (downCounter == 2)
                {
                    MenuDisplay();
                    Console.ResetColor();
                    OnlyOptions();
                    if (button == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        return 2;
                    }
                }
                if (downCounter == 3)
                {
                    MenuDisplay();
                    Console.ResetColor();
                    OnlyHowToPlay();
                    if (button == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        return 3;
                    }
                }
                if (downCounter == 4)
                {
                    MenuDisplay();
                    Console.ResetColor();
                    OnlyLeave();
                    if (button == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        return 4;
                    }
                }
                if (downCounter > 4)
                {
                    downCounter = 0;
                }
                if (downCounter <0)
                {
                    downCounter = 4;
                }
            } while (true);
        }
        /// <summary>
        /// Displays menu options 
        /// </summary>
        public static void MenuDisplay()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(0, 0);
            var play = new StreamReader(@"..\..\Menu\Play.txt");
            Console.WriteLine(play.ReadToEnd());

            var options = new StreamReader(@"..\..\Menu\Options.txt");
            Console.WriteLine(options.ReadToEnd());

            var howToPlay = new StreamReader(@"..\..\Menu\HowToPlay.txt");
            Console.WriteLine(howToPlay.ReadToEnd());

            var leave = new StreamReader(@"..\..\Menu\LeaveUs.txt");
            Console.WriteLine(leave.ReadToEnd());
        }
        /// <summary>
        /// Displays "Play" option from main menu
        /// </summary>
        public static void Onlyplay()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Cyan;
            var play = new StreamReader(@"..\..\Menu\Play.txt");
            Console.WriteLine(play.ReadToEnd());
        }
        /// <summary>
        /// Displays "Options" option from main menu
        /// </summary>
        public static void OnlyOptions()
        {
            Console.SetCursorPosition(0, 12);
            Console.ForegroundColor = ConsoleColor.Cyan;
            var options = new StreamReader(@"..\..\Menu\Options.txt");
            Console.WriteLine(options.ReadToEnd());
        }
        /// <summary>
        /// Displays "How to play" option from main menu
        /// </summary>
        public static void OnlyHowToPlay()
        {
            Console.SetCursorPosition(0, 23);
            Console.ForegroundColor = ConsoleColor.Cyan;
            var howToPlay = new StreamReader(@"..\..\Menu\HowToPlay.txt");
            Console.WriteLine(howToPlay.ReadToEnd());
        }
        /// <summary>
        /// Displays "Leave us" options from main menu
        /// </summary>
        public static void OnlyLeave()
        {
            Console.SetCursorPosition(0, 33);
            Console.ForegroundColor = ConsoleColor.Cyan;
            var leave = new StreamReader(@"..\..\Menu\LeaveUs.txt");
            Console.WriteLine(leave.ReadToEnd());
        }
        /// <summary>
        /// Displays welcome screen
        /// </summary>
        /// <param name="width" takes given width for console></param>
        /// <param name="height" takes given height for console></param>
        public static void WellcomeScreen(int width, int height)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var wellcomeMessage = new StreamReader(@"..\..\WellcomeScreen\Wellcome.txt");
            Console.WriteLine(wellcomeMessage.ReadToEnd());
            Thread.Sleep(400);
            Console.SetCursorPosition(width - 25, height - 5);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("By team \"Thunderbird\"");
            Thread.Sleep(3000);
            Console.Clear();
        }
        /// <summary>
        /// Displays options screen
        /// </summary>
        public static void SoundOptions()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(0, 0);
            var soundOption = new StreamReader(@"..\..\Menu\OptionsSound.txt");
            Console.WriteLine(soundOption.ReadToEnd());
        }
        /// <summary>
        /// Displays toggle to switch sound on
        /// </summary>
        public static void SoundOn()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 14);
            var soundOptionON = new StreamReader(@"..\..\Menu\SoundON.txt");
            Console.WriteLine(soundOptionON.ReadToEnd());
            Console.ResetColor();
        }
        /// <summary>
        /// Displays toggle to switch sound off
        /// </summary>
        public static void SoundOff()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 18);
            var soundOptionOFF = new StreamReader(@"..\..\Menu\SoundOFF.txt");
            Console.WriteLine(soundOptionOFF.ReadToEnd());
            Console.ResetColor();
        }
        /// <summary>
        /// Toggles sound options 
        /// </summary>
        /// <returns>boolean expression for choosen option, true for on, false for off</returns>
        public static bool OptionsMovement()
        {
            ConsoleKey button;
            int buttonCounter = 0;
            SoundOptions();
            do
            {
                button = Console.ReadKey(true).Key;
                Console.SetCursorPosition(0, 0);

                if (button == ConsoleKey.DownArrow)
                {
                    if (buttonCounter == 2)
                    {
                        buttonCounter = 1;
                    }
                    else
                    {
                        buttonCounter++;
                    }
                }
                if (button == ConsoleKey.UpArrow)
                {
                    if (buttonCounter == 1)
                    {
                        buttonCounter = 2;
                    }
                    else
                    {

                    
                    buttonCounter--;
                    }
                }
                if (buttonCounter == 1)
                {
                    SoundOptions();
                    Console.ResetColor();
                    SoundOn();
                    if (button == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        sound = true;
                        return sound; // means true
                    }
                }
                if (buttonCounter == 2)
                {
                    SoundOptions();
                    Console.ResetColor();
                    SoundOff();
                    if (button == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        sound = false;
                        return sound; // means false
                    }
                }
                if (buttonCounter > 2 || buttonCounter <= 0)
                {
                    buttonCounter = 0;
                }
            } while (true);
        }
        /// <summary>
        /// Аssigns bool value to bool variable
        /// </summary>
        /// <param name="isSound" takes true if sound is on, takes false if sound is off></param>
        /// <returns>bool variable </returns>
        public static bool CheckSound(bool isSound)
        {
            isSound = sound;
            return isSound;
        }       
       
    }
}

