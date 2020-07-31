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
                Console.WriteLine("press Enter");
                enteredText = Console.ReadLine();
                studentCounter++;
                Console.WriteLine("current student number is : {0}" , studentCounter);
            } 
            Console.Write((studentCounter -= 1 ) + " students entered");
        } 
           
    }
}
