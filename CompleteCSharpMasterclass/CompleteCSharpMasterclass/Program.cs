using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Media;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            // declare jagged array
            int [][] jaggedArray = new int[3][]; 
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int [3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new[] {2, 3, 5, 7, 11};
            jaggedArray[1] = new[] {1, 2, 3};
            jaggedArray[2] = new[] {13,21};
            
            //alternative way to declare jagged array.
            int[][] jaggedArray2 = new int [][]
            {
                new int[] {2, 3, 5, 7, 11},
                new int[] {1, 2, 3},
                new int[] {13,21}
            };

            Console.WriteLine("the value in array 0 third index is {0}", jaggedArray2[0][2]);

            for (int i =0 ; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);

                for (int j = 0 ; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0} ", j);
                }
                
            }

            Console.WriteLine("Done counting");
           */

            string[][] friendsAndFamily = new string[][]
            {
                new string[] {"Maria", "Liliana"},
                new string[] {"Igal", "Ran"},
                new string[] {"David", "Joe"}
            };
            Console.WriteLine("Hi, {0}, i would like to introduce {1} to you...", friendsAndFamily[0][0] , friendsAndFamily[1][1]);
            Console.WriteLine("Hi, {0}, i would like to introduce {1} to you...", friendsAndFamily[0][1] , friendsAndFamily[1][0]);
            Console.WriteLine("Hi, {0}, i would like to introduce {1} to you...", friendsAndFamily[2][1] , friendsAndFamily[0][1]);
        }

    }
}



    

