using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Media;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int[] happinessArray = new[] {2, 3, 4, 5, 6};
            
            SunIsShining(happinessArray);

            int index = 0;// wanted to have index. for eace loops dont have index.. so i made an external variable and used it as the index of the array.
            
            foreach (var element in happinessArray)
            {
                
                Console.WriteLine("happiness at {0} is: {1}" , index , element);
                index++;
            }
        }

        static void SunIsShining(int[] x) // it will also assign these new values to the happiness array!!!! 
        {
            for(int i = 0 ; i < x.Length ; i++)
            {
                x[i] += 2;
                
                //Console.WriteLine("{0}" , x[i]);
            }
        }
    }
}



    

