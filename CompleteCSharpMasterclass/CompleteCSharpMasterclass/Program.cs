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
                Console.WriteLine("enter score: (enter -1 to exit)");
                userInput = Console.ReadLine();
                
                //things that validate the input..
                bool isValid = int.TryParse(userInput, out  userInputInt);
                bool isInRange = userInputInt > 0 && userInputInt < 20;
                bool isNotMinusOne = userInput != "-1";
                
                if (isValid && isInRange)
                {
                    totalScore += userInputInt; 
                    counterStudents++;
                    //debug process
                    Console.WriteLine("user input was: " + userInput);
                    Console.WriteLine("total score is: " + totalScore);
                    Console.WriteLine("student counter is: " + counterStudents);
                }
                else if(isNotMinusOne && !isInRange)
                {
                    Console.WriteLine("number is not in range, or is a letter..");
                }
                else
                {
                    Console.WriteLine("You have exited");
                    break;
                }
            }
            //calculate and print Average.
            Console.WriteLine("The average is: {0}", (totalScore / counterStudents) );
        }
        
    }
}
