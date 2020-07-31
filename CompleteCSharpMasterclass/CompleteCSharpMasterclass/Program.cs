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
            int currentInputNumber = 0;
            int totalScore = 0;
            
            
            
            while (userInput != "-1")
            {
                Console.WriteLine("enter score: ");
                userInput = Console.ReadLine();
                bool isValid = int.TryParse(userInput, out  currentInputNumber);
                if (isValid)
                {
                    totalScore += currentInputNumber;
                    counterStudents++;
                }
            }
            Console.WriteLine("The average is: {0}", (totalScore / counterStudents) );
        }
        
    }
}
