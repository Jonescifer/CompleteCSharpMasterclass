using System;
using System.Diagnostics.Eventing.Reader;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            
            //my take
            int studentCounter = 0;
            string enteredText = "";
            
            while (enteredText.Equals (""))
            {
                Console.WriteLine("press Enter to count");
                enteredText = Console.ReadLine();
                studentCounter++;
                //been looking for this my whole life! wanted it to not say the last pressed Enter into the count and display it. it always showed 1 more!
                if (enteredText.Equals (""))
                {
                    Console.WriteLine("current student number is : {0}" , studentCounter);
                }
            } 
            Console.Write((studentCounter -= 1) + " students entered");
        } 
           
    }
}
