using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderBird
{
    class Player
    {
      
        private string playerName;
        private int playerMoves;
        private int playerTimeMins;
        private int playerTimeSecs;
        private int difLevel;
      
        //***************************************************************************
        /// <summary>
        /// Gets player data - name, time for game play, moves count, ect.
        /// </summary>
        public int DifLevel
        {
            get { return this.difLevel; }
            private set { this.difLevel = value; }
        }
        public string PlayerName
        {
            get { return this.playerName; }
            private set { this.playerName = value; }
        }
        public int PlayerMoves
        {
            get { return this.playerMoves; }
           private set { this.playerMoves = value; }
        }
        public int PlayerTimeMins
        {
            get { return this.playerTimeMins; }
           private set { this.playerTimeMins = value; }
        }
        public int PlayerTimeSecs
        {
            get { return this.playerTimeSecs; }
           private set { this.playerTimeSecs = value; }
        }
        public Player(string name, int level)
        {
            this.playerName = name;
            this.difLevel = level;
        }
        public void SetPlayerScore(int moves, int timeM, int timeS)
        {
            this.PlayerMoves = moves;
            this.PlayerTimeMins = timeM;
            this.PlayerTimeSecs = timeS;
        }
        //***************************************************************************

        /// <summary>
        /// Save game results in an external .txt file
        /// </summary>
        public void SaveScore()
        {
            StreamWriter writer = new StreamWriter(@"..\..\" + this.PlayerName + ".txt", true);
            using (writer)
            {

                writer.WriteLine(this.DifLevel + "/" + this.PlayerMoves + "/"
                    + this.PlayerTimeMins + "/" + this.PlayerTimeSecs);
            }
        }



        /// <summary>
        /// Displays results of the current game play
        /// </summary>
        public void DisplayScore()
        {            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("moves: {0}", this.PlayerMoves);
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (this.PlayerTimeSecs < 9)
            {
                Console.Write("\t time: {0}:0{1}", this.PlayerTimeMins, this.PlayerTimeSecs);          
            }
            else
            {
                Console.Write("\t time: {0}:{1}", this.PlayerTimeMins, this.PlayerTimeSecs);                
            }
            Console.ResetColor();
            Console.WriteLine();                      
        }

       
        /// <summary>
        /// Displays all the results of the current player
        /// </summary>
        public void DisplayHighScores()
        {
            Console.WriteLine();
            List<int> stats = new List<int>();
            StreamReader scoreread = new StreamReader(@"..\..\" + this.PlayerName + ".txt");
            using (scoreread)
            {
                string line = String.Empty;
                while (true)
                {
                    line = scoreread.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] scores = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < scores.Length; i++)
                    {
                        stats.Add(int.Parse(scores[i]));
                    }
                }

                Console.WriteLine("player: {0}. ", this.PlayerName);
                for (int a = 0; a < stats.Count; a += 4)
                {
                    
                    Console.Write("level: {0}x{0}. ", stats[a]);
                    Console.Write("moves: {0}. ", stats[a + 1]);
                    Console.Write("time: {0}:", stats[a + 2]);
                    if (this.PlayerTimeSecs < 9)
                    {
                        Console.Write("0{0}", stats[a + 3]);
                    }
                    else
                    {
                        Console.Write("{0}", stats[a + 3]);
                    }
                   
                    Console.WriteLine();
                }
            }
        }
    }
}
