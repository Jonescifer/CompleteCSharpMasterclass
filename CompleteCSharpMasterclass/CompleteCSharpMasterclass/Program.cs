using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        private static void Main(string[] args)
        {
            
           //method 1
            string [] newList = {"first line", "second line", "third line" };
           File.WriteAllLines(@"/Users/paulwolf/Desktop/textFile2.txt" , newList);

           string[] highScoreList = {"1000", "500", "250" };
           File.WriteAllLines(@"/Users/paulwolf/Desktop/highScores.txt" , highScoreList);
           
           // method 2
           Console.WriteLine("Please give the file a name.");
           string fileName = Console.ReadLine();
           Console.WriteLine("please type text in file");
           string input = Console.ReadLine();
           File.WriteAllText(@"/Users/paulwolf/Desktop/" + fileName + ".txt" , input);
           
           //method 3
           using(StreamWriter file = new StreamWriter(@"/Users/paulwolf/Desktop/TextFile.txt"))
           {
               foreach (string line in newList)
               {
                   if (line.Contains("line"))
                   {
                       file.WriteLine(line);
                   }
                   
               }
           }
           //adding a line to a text file that already exists..
           using (StreamWriter file = new StreamWriter(@"/Users/paulwolf/Desktop/TextFile.txt", true))
           {
               file.WriteLine("additional line..");
           }
           

           
           //example 1 - reading text from file.
           string text = System.IO.File.ReadAllText(@"/Users/paulwolf/Desktop/textFile.txt");
           Console.WriteLine($"the text is: \n{text}");
           
           //example 2 - list..

           string[] linesList = System.IO.File.ReadAllLines(@"/Users/paulwolf/Desktop/textFile.txt");
           Console.WriteLine($"the text is: \n");// \n is new line.
           foreach (var line in linesList)
           {
               Console.WriteLine("\t " + line);// the /t is TAB indentation..
           }
          
        }
    }
}



    

