using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        public struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

           //doesnt have a default constructor - i.e. empty.... null...
           //public Game(){}
            public Game(string name, string developer,double rating, string releaseDate)
            { 
                this.name = name;
                this.developer = developer;
                this.rating = rating;
                this.releaseDate = releaseDate;
            }
            
            public void DisplayInfo()
            { 
                Console.WriteLine($"The game {name} was released by {developer}, on {releaseDate} and it's rating is {rating}."); 
            }
        }
        
        private static void Main(string[] args)
        {
            //have to assign all the variables before using it's methods!
            var game1 = new Game("Pokemon Go","Niantic",3.5,"01.07.2016");
            game1.DisplayInfo();
            
        }
    }
}



    

