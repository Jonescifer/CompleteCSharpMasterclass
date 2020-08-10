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
            
            
                /*
                for (row = 0; row < 9; row++)
                {
                    for (index=0 ; index < 12 ; index++) // needed to tell what row is e.g int row=0 and not row=0;
                    {
                        Console.Write(ticTacToe.GetValue(index)); // was not goot - needed two values row and index
                    }
                    Console.WriteLine();
                }
                */

                
                /*
                 //prints array in one line per index - not good fo me..
                 
                foreach (string i in ticTacToe)
                {
                    Console.WriteLine("{0}", i);
                } 
                for (int k = 0; k < 10; k++) // better to use GetLength!
                { 
                    for (int l=0 ; l < 11 ; l++) 
                    { 
                        Console.Write(ticTacToe[k,l]); 
                    } 
                    Console.WriteLine();
                    } 
                */

                static void ShowGame(string[]ticTacToe)
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
                
                
        }
    }
}


