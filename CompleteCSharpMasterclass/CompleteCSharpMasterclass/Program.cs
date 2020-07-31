using System;
using System.Diagnostics.Eventing.Reader;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        public static void Main(string[] args)
       {
          
           Console.WriteLine("enter temperature:");
           CheckTemperature(Console.ReadLine());
           
       }

       static void CheckTemperature(string temprerature )
       {
           string myBody;
           
           if(int.TryParse(temprerature, out int intTemperature))
           {
               myBody = intTemperature <= 15 ? "its to cold here" : intTemperature >= 16 && intTemperature <= 28  ? "its ok here" : "its to hot here";
               Console.WriteLine("My Body is telling me that {0}!", myBody);     
           }
           else
           {
               Console.WriteLine("Not a valid temperature value, bianca.");           
           }
           
       }
    }
}

  //stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
    //                  Console.WriteLine("state of matter is {0} ", stateOfMatter);