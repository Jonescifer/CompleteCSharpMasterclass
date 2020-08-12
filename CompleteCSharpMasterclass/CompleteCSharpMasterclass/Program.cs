using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class Program
    {
        static bool _playerOneWin = false;
        static bool _playerTwoWin = false;
        static bool _gameWon = false;
        static int _currentPlayer = 1; // at the beginning the first player is 1
        static string[,] arrayTicTacToe =
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
            ShowGame(arrayTicTacToe);
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
            while (!_gameWon)
            {
                CheckUserInput(); 
                if (_playerOneWin || _playerTwoWin)
                { 
                    Console.WriteLine("Player {0} has won!" , _currentPlayer ); 
                    break;
                }
            }
        }
        
        static void CheckUserInput()
        {
            //ask user for input.
            Console.WriteLine("Player {0}: Choose your field!", _currentPlayer);
            
            // check if is a number and return it.
            var isNumeric = int.TryParse(Console.ReadLine(), out int intPlayerInput);

            if (isNumeric && intPlayerInput > 0 && intPlayerInput <= 9 )
            {
                switch (_currentPlayer)
                {
                    case (1):
                        EditArray(intPlayerInput);
                        CheckWinStatus(); //must set _gameWon to true if player wins
                        if (_gameWon)
                        {
                            break;
                        }
                        _currentPlayer = 2;
                        break;
                    case(2):
                        EditArray(intPlayerInput);
                        CheckWinStatus(); //must set _gameWon to true if player wins
                        if (_gameWon)
                        {
                            break;
                        }
                        _currentPlayer = 1;
                        break;
                }
            }
            //wrong input entered
            Console.WriteLine("Please enter a valid number between 1 and 9!");
        }

        static void EditArray(int intPlayerInput)
        
        {
            string mark = "";
            
            switch (_currentPlayer)
            {
                case(1):
                    mark = "X";
                    break;
                case(2):
                    mark = "O";
                    break;
            }
            /*
            switch (intPlayerInput)
            {
                case(1):
                    arrayTicTacToe[1,1] = mark;
                    break;
            }
            */
            //loop through array - failed maybe Denis will do it..
            for (var i = 0; i < arrayTicTacToe.GetLength(0); i++)
            {
                for (var j = 0; j < arrayTicTacToe.GetLength(1); j++)
                {
                    if (arrayTicTacToe[i, j] == intPlayerInput.ToString())
                    {
                        arrayTicTacToe[i, j] = mark;
                    }
                }

            }
        }

        static void CheckWinStatus()
        {
            _gameWon = false;
            _gameWon = true;
        }
    }
}


