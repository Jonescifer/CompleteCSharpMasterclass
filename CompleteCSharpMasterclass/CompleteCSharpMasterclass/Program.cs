using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CompleteCSharpMasterclass
{
    internal class MainClass
    {
        private static void Main(string[] args)
        {
            int? num1 = null;
            //int num2 = null; cant work.
            int? num2 = 1337;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolVal = new bool?();

            Console.WriteLine($"Nullable numbers are:{num1},{num2},{num3},{num4}.");//the null is no value!
            Console.WriteLine($"The nullable bool is:{boolVal}.");

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("user is male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("user is feale");
            }
            else
            {
                Console.WriteLine("User didnt define gender");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;
            //assigning a number to num8 if num6 is null or not - the long way......
            if (num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;// cannot implicitly convert type 'double?' to 'double'. An explicit conversion  exists (are you missing a cast?)
            }
            Console.WriteLine($"value of num8 is {num8}");
            
            
            
            //shorter version with
            //'Null Coalescing Operator'
            
            //num6 is not 'null' - so num 8 wont get this new value.
            num8 = num6 ?? 8.3;
            Console.WriteLine($"value of num8 is {num8}");
            
            //num7 is 'null' - so num8 will get 8.3
            num8 = num7 ?? 8.3;
            Console.WriteLine($"value of num8 is {num8}");
        }
    }
}



    

