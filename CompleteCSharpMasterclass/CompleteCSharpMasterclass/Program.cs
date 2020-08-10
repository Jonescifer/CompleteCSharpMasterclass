using System;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[,] ticTacToe =
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
            
            ShowGame(ticTacToe);
            UserInput();
            CheckGame(ticTacToe);


        }

        static void ShowGame(string[,] ticTacToe)
        {
            
            
            for (int i = 0; i < ticTacToe.GetLength(0); i++)
            { 
                for (int j = 0; j < ticTacToe.GetLength(1); j++)  
                { 
                    Console.Write("{0}" , ticTacToe[i,j]);
                } 
                Console.WriteLine();
            }
        }

        static int UserInput()
        {
            string input = Console.ReadLine();
            
            //if is int 1-9 return intInput.
            
            return intInput;
        }
        
    }
}


