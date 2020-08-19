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

        /*
         TURNS OUT I DIDNT UNDERSTAND THIS!!!! I DIDNT UNDERSTAND HOW TO CHANGE THE happinessARRAY, i thought i only changed the x array inside the method. BUT NO! an array is a reference type. so you make changes to the actual argument( happiness array)!!!
         
         Why you can change an array by passing it as a variable
         If you tried to run the Method call SunIsShining(happiness);  without assigning it to happiness you might have realized, that happiness itself is changed. Why is that?
         Arrays are a reference type in C#. This means that each time an array is passed as an argument to any function, the reference (or pointer) to the argument is passed to the function.
         Thus any modifications you make to the array in the function are made in the actual argument also
        */
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



    

