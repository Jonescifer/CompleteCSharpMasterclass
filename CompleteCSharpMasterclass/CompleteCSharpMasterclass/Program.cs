using System;
using System.Diagnostics.Eventing.Reader;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CheckTemperature(UserInput());
        }

        static string UserInput()
        {
            Console.WriteLine("enter temperature:");
            string userInput = Console.ReadLine();
            return userInput;
        }
        static void CheckTemperature(string useInput )
        { 
            string feeling;
            
            //validate the input as a valid integer value
            bool validInt = int.TryParse(useInput, out int intTemperature);
           
            if(validInt)
            { 
                feeling = intTemperature <= 15 ? "its to cold here" : intTemperature >= 16 && intTemperature <= 28  ? "its ok here" : "its to hot here";
               Console.WriteLine(feeling); 
            }
            else 
            {
               Console.WriteLine("Not a valid temperature value, bianca."); 
            }
        }
    }
}
