using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class Program
    {
        static bool _gameWon;
        private static bool _gameDraw = false;
        static int _currentPlayer = 1; // at the beginning the first player is 1

        static string[,] arrayTicTacToe =
        {
            //0    1    2    3    4    5    6    7    8    9  
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " "}, //0
            {" ", "1", " ", "|", " ", "2", " ", "|", " ", "3"}, //1
            {"_", "_", "_", "|", "_", "_", "_", "|", "_", "_"}, //2
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " "}, //3
            {" ", "4", " ", "|", " ", "5", " ", "|", " ", "6"}, //4
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " "}, //5
            {"_", "_", "_", "|", "_", "_", "_", "|", "_", "_"}, //6
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " "}, //7
            {" ", "7", " ", "|", " ", "8", " ", "|", " ", "9"}, //8
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " "} //9
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
                    Console.Write("{0}", ticTacToe[i, j]);
                }

                Console.WriteLine();
            }
        }

        static void RunGame()
        {
            while (!_gameWon || !_gameDraw)
            {
                CheckGameStatus();
                Console.Clear();
                ShowGame(arrayTicTacToe);
                if (_gameWon)
                {
                    Console.WriteLine("Player {0} has won!", _currentPlayer);
                    break;
                }

                if (_gameDraw)
                {
                    Console.WriteLine("Its a draw!");
                    break;
                }
            }
        }

        static void CheckGameStatus()
        {
            //ask user for input.
            Console.WriteLine("Player {0}: Choose your field!", _currentPlayer);

            // check if is a number and return it.
            var isNumeric = int.TryParse(Console.ReadLine(), out int intPlayerInput);

            if (isNumeric && intPlayerInput > 0 && intPlayerInput <= 9)
            {
                switch (_currentPlayer)
                {
                    case 1:
                        EditArray(intPlayerInput);
                        CheckWinStatus();
                        _currentPlayer = 2;
                        break;
                    case 2:
                        EditArray(intPlayerInput);
                        CheckWinStatus();
                        _currentPlayer = 1;
                        break;
                }
            }
            else
            {
                //wrong input entered
                Console.WriteLine("Please enter a valid number between 1 and 9!");
                Console.ReadKey();
            }

        }

        static void EditArray(int intPlayerInput)

        {
            string mark = "";

            switch (_currentPlayer)
            {
                case 1:
                    mark = "X";
                    break;
                case 2:
                    mark = "O";
                    break;
            }

            //run through array (need to do this 1000 times to remember it 
            for (var i = 0; i < arrayTicTacToe.GetLength(0); i++)
            {
                for (var j = 0; j < arrayTicTacToe.GetLength(1); j++)
                {
                    if (arrayTicTacToe[i, j] == intPlayerInput.ToString()
                    ) // if inputted number is the same as "slot number" in array. :) 
                    {
                        arrayTicTacToe[i, j] = mark;
                    }
                }

            }
        }

        static void CheckWinStatus()
        {
            //Horizontal Win
            if (arrayTicTacToe[1, 1] == arrayTicTacToe[1, 5] && arrayTicTacToe[1, 5] == arrayTicTacToe[1, 9])
            {
                _gameWon = true;
            }

            if (arrayTicTacToe[4, 1] == arrayTicTacToe[4, 5] && arrayTicTacToe[4, 5] == arrayTicTacToe[4, 9])
            {
                _gameWon = true;
            }

            if (arrayTicTacToe[8, 1] == arrayTicTacToe[8, 5] && arrayTicTacToe[8, 5] == arrayTicTacToe[8, 9])
            {
                _gameWon = true;
            }

            //Vertical Win
            if (arrayTicTacToe[1, 1] == arrayTicTacToe[4, 1] && arrayTicTacToe[4, 1] == arrayTicTacToe[8, 1])
            {
                _gameWon = true;
            }

            if (arrayTicTacToe[1, 5] == arrayTicTacToe[4, 5] && arrayTicTacToe[4, 5] == arrayTicTacToe[8, 5])
            {
                _gameWon = true;
            }

            if (arrayTicTacToe[1, 9] == arrayTicTacToe[4, 9] && arrayTicTacToe[4, 9] == arrayTicTacToe[8, 9])
            {
                _gameWon = true;
            }

            //Diagonal Win
            if (arrayTicTacToe[1, 1] == arrayTicTacToe[4, 5] && arrayTicTacToe[4, 5] == arrayTicTacToe[8, 9])
            {
                _gameWon = true;
            }

            if (arrayTicTacToe[1, 9] == arrayTicTacToe[4, 5] && arrayTicTacToe[4, 5] == arrayTicTacToe[8, 1])

            {
                _gameWon = true;
            }

            if (AllFieldsFull())
            {
                _gameDraw = true;
            }
        }

        static bool AllFieldsFull()
        {
            for (var i = 0; i < arrayTicTacToe.GetLength(0); i++)
            {
                for (var j = 0; j < arrayTicTacToe.GetLength(1); j++)
                {
                    if ((arrayTicTacToe[i, j].Contains("1")) || (arrayTicTacToe[i, j].Contains("2")) || (arrayTicTacToe[i, j].Contains("3")) || (arrayTicTacToe[i, j].Contains("4"))|| (arrayTicTacToe[i, j].Contains("5"))|| (arrayTicTacToe[i, j].Contains("6"))|| (arrayTicTacToe[i, j].Contains("7"))|| (arrayTicTacToe[i, j].Contains("8")) || (arrayTicTacToe[i, j].Contains("9")))
                    {
                        return  false;
                    }

                }
            }

            return true;
        }
    }

}


