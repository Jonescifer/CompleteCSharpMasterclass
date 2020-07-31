using System;
using System.Diagnostics.Eventing.Reader;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        static int highScore = 20;
        static string highScorePlayer = "Josh";
       
        public static void Main(string[] args)
        {
            CheckHighScore(19,"Jones");
            CheckHighScore(21,"Josh");
        }

        static void CheckHighScore(int score, string playerName)
        {
            if (score > highScore)
            {
                 highScore = score;
                 highScorePlayer = playerName;
                 Console.WriteLine("New high score! High score is: {0}, by {1}", highScore,highScorePlayer);
            }
            else

            {
                Console.WriteLine("No new high score. High score is still: {0}, by {1}", highScore,highScorePlayer);
                
            }
            
        }

    }
}

