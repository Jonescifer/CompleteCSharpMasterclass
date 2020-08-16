using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Media;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    public class temp
    {
        public static char[,] playField =
        {
            //0  //1  //2
            {'1', '2', '3'},// 0
            {'4', '5', '6'},// 1
            {'7', '8', '9'} // 2
        };
        
        public static char[,] playFieldInitial =
        {
            //0  //1  //2
            {'1', '2', '3'},// 0
            {'4', '5', '6'},// 1
            {'7', '8', '9'} // 2
        };
          
        static int turns = 0;
        
        public static void Main(string[] args)
        {
            int player = 2;
            int input = 0;//no case for 0 in EnterXorO method so no worries its going to be changed at start of game!
            bool inputCorrect = true;
          


            do //Run code as long as program runs... duh (or not! Duh)
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input); //no case for 0 in EnterXorO method so no worries its going to be changed at start of game!
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input); //no case for 0 in EnterXorO method so no worries its going to be changed at start of game!
                }

                SetField();

                #region Check winning condition

                char[] playerChars = {'X','O'};

                foreach (char playerChar in playerChars)
                {
                    if(((playField[0,0] == playerChar) && (playField[0,1] == playerChar) && (playField[0,2] == playerChar))
                        || ((playField[1,0] == playerChar) && (playField[1,1] == playerChar) && (playField[1,2] == playerChar))
                        || ((playField[2,0] == playerChar) && (playField[2,1] == playerChar) && (playField[2,2] == playerChar))
                        || ((playField[0,0] == playerChar) && (playField[1,0] == playerChar) && (playField[2,0] == playerChar))
                        || ((playField[0,1] == playerChar) && (playField[1,1] == playerChar) && (playField[2,1] == playerChar))
                        || ((playField[0,2] == playerChar) && (playField[1,2] == playerChar) && (playField[2,2] == playerChar))
                        || ((playField[0,0] == playerChar) && (playField[1,1] == playerChar) && (playField[2,2] == playerChar))
                        || ((playField[2,0] == playerChar) && (playField[1,1] == playerChar) && (playField[0,2] == playerChar))
                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nplayer 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\nplayer 1 has won!");
                        }

                        Console.WriteLine("press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        player = 1;//to reset to player 1.... duh
                        break;
                    }
                    else if (turns==10)
                    {
                        Console.WriteLine("WE HAVE A DRAW! \npress any key to reset the game!");
                        Console.ReadKey();
                          ResetField();
                          player = 1;
                          break;
                    }
                }
                

                #endregion
                #region Check user input and if filed is already taken...

                do
                {
                    Console.Write("\nPlayer {0}: Choose your field!", player);
                    try
                    {
                        input = Convert.ToInt16(Console.ReadLine()); // i uset try parse and throw message if it wasnt a number.. couse this is how i roll..
                    }
                    catch
                    {
                        Console.WriteLine("please enter a number");
                        Console.ReadKey();
                    }
                    if ((input == 1) && (playField[0,0]=='1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0,1]=='2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0,2]=='3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1,0]=='4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1,1]=='5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1,2]=='6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2,0]=='7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2,1]=='8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2,2]=='9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("field taken, use another field.");
                        inputCorrect = false;
                    }
                    

                } while (!inputCorrect);
                #endregion
            } while (true);
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  " , playField[0,0],playField[0,1],playField[0,2]);
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine("  {0}  |  {1}  |  {2}  " , playField[1,0],playField[1,1],playField[1,2]);
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine("  {0}  |  {1}  |  {2}  " , playField[2,0],playField[2,1],playField[2,2]);
            Console.WriteLine("     |     |     ");
            turns++; // counts turns!
        }

        public static void ResetField()
        {
            playField = playFieldInitial;
            SetField();
            turns = 0;
        }
        

        public static void EnterXorO(int player , int input)
        {
            char playerMark=' ';// need to check player 1 is O..
            if (player==1)
            {
                playerMark = 'X';
            }else if(player==2)

            {
                playerMark = 'O';
            }
            switch (input)
            {
                case 1: playField[0, 0] = playerMark; break;
                case 2: playField[0, 1] = playerMark; break;
                case 3: playField[0, 2] = playerMark; break;
                case 4: playField[1, 0] = playerMark; break;
                case 5: playField[1, 1] = playerMark; break;
                case 6: playField[1, 2] = playerMark; break;
                case 7: playField[2, 0] = playerMark; break;
                case 8: playField[2, 1] = playerMark; break;
                case 9: playField[2, 2] = playerMark; break;
            }
        }
    }
}