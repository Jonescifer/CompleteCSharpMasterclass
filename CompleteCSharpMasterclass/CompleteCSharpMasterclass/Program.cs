using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {

        private static void Main(string[] args)
        {
            Console.WriteLine($"ceiling of 12.1 is: {Math.Ceiling(12.1)}");
            Console.WriteLine($"flooring of 12.1 is: {Math.Floor(12.1)}");

            int num1 = 13;
            int num2 = 9;
            
            Console.WriteLine($"Lower of {num1} and {num2} is {Math.Min(num1,num2)}");
            Console.WriteLine($"Higher of {num1} and {num2} is {Math.Max(num1,num2)}");
            Console.WriteLine($"3 to power of 5 of is {Math.Pow(3,5)}");
            Console.WriteLine($"Pi is {Math.PI}");
            Console.WriteLine($"square root of 25 is {Math.Sqrt(25)}");
            Console.WriteLine($"Absolute number (always positive) of -25 is: {Math.Abs(-25)}");
            Console.WriteLine($"Cosine of 1 is {Math.Cos(1)}");

        }
    }
}



    

