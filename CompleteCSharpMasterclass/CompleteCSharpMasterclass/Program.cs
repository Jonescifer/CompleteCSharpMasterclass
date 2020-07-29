using System;

namespace OperatorsC
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            CheckTemperature(AskUser());
        }

        static int AskUser()
        {
            Console.WriteLine("please enter temperature outside!");
            string userInput = Console.ReadLine();
            int trueNumber;
            if(int.TryParse(userInput,out trueNumber))
            {
                return trueNumber;
            }
            else
            {
                trueNumber = 0;
                Console.WriteLine("You are stupid - enter only numbers");
                return trueNumber;
            }
            
        }
        
        static void CheckTemperature(int trueNumber)
        {
            
            if (trueNumber < 20)
            {
                Console.WriteLine("{0}, Stay home", trueNumber);
            }
            else if (trueNumber == 20)
            {
                Console.WriteLine("{0}, Put coat and go outside", trueNumber);
            }
            else
            {
                Console.WriteLine("{0}, Go to the Beach", trueNumber);
            }
                
        }
        
    }
}
