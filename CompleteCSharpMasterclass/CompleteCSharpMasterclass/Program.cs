using System;
using System.Diagnostics.Eventing.Reader;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInput = "0";
            int counterStudents = 0;
            int userInputInt = 0;
            int totalScore = 0;
            
            
            
            while (userInput != "-1")
            {
                Console.WriteLine("enter score: ");
                userInput = Console.ReadLine();
                bool isValid = int.TryParse(userInput, out  userInputInt) && (userInput != "-1");
                if (isValid)
                {
                    totalScore += userInputInt;
                    counterStudents++;
                    
                    //debug process
                    Console.WriteLine("user input was: " + userInput);
                    Console.WriteLine("total score is: " + totalScore);
                    Console.WriteLine("student counter is: " + counterStudents);
                }
            }
            //calculate and print Average.
            Console.WriteLine("The average is: {0}", (totalScore / counterStudents) );
        }
        
    }
}
