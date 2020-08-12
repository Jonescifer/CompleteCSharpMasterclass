using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class Program
    {
        static bool playerOneWin = false;
        static bool playerTwoWin = false;
        static bool gameWon = false;
        static int playerNumber = 0;
        static string[,] ticTacToe =
                    {
                        {" "," "," ","|"," "," "," ","|"," "," "," "},
                        {" ","1"," ","|"," ","2"," ","|"," ","3"," "},
                        {"_","_","_","|","_","_","_","|","_","_","_"},
                        {" "," "," ","|"," "," "," ","|"," "," "," "},
                        {" ","4"," ","|"," ","5"," ","|"," ","6"," "},
                        {" "," "," ","|"," "," "," ","|"," "," "," "},
                        {"_","_","_","|","_","_","_","|","_","_","_"},
                        {" "," "," ","|"," "," "," ","|"," "," "," "},
                        {" ","7"," ","|"," ","8"," ","|"," ","9"," "},
                        {" "," "," ","|"," "," "," ","|"," "," "," "}
                    };
        
        
        public static void Main(string[] args)
        {
            ShowGame(ticTacToe);
            RunGame();
            
        }
        static void ShowGame(string[,] ticTacToe)
        {
            for (var i = 0; i < ticTacToe.GetLength(0); i++)
            { 
                for (var j = 0; j < ticTacToe.GetLength(1); j++)  
                { 
                    Console.Write("{0}" , ticTacToe[i,j]);
                } 
                Console.WriteLine();
            }
        }
        static void RunGame()
        {
            while (!gameWon)
            { 
                CheckGame(ticTacToe); 
                if (playerOneWin || playerTwoWin)
                { 
                    Console.WriteLine("Player {0} has won!" , playerNumber ); 
                    break;
                }
            }
        }
        
        static void CheckGame(string [,] ticTacToe)
        {
            //ask user for input.
            Console.WriteLine("Player 1: Choose your field!");
            
            // check if is a number and return it.
            var isNumeric = int.TryParse(Console.ReadLine(), out int intPlayerInput);

            if (isNumeric)
            {
                if (intPlayerInput != 0 && intPlayerInput <= 9)
                {
                    
                }
            }
            //wrong input entered
            Console.WriteLine("Please enter a valid number between 1 and 9!");
        }

        
    }
}


