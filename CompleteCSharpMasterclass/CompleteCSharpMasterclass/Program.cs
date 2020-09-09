using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        // Enums a re there to share a set of constants to keep the library consistent.
        private enum Day
        {
            Su,
            Mo,
            Tu,
            We,
            Th,
            Fr,
            Sa
        };

        private enum Month
        {
            Jan=1,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul=12,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        };
        
        private static void Main(string[] args)
        {
            var friday = Day.Fr;
            var sunday = Day.Su;
            var dayA = Day.Fr;

            Console.WriteLine(friday==dayA);
            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Su);

            Console.WriteLine((int)Month.Feb);
            Console.WriteLine((int)Month.Aug);
        }
    }
}



    

