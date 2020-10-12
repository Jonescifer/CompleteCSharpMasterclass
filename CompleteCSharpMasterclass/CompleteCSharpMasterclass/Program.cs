using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        
        private static void Main(string[] args)
        {
            int [] numbers = new int[]{1,2,3,4,5,6,7,8,9};
            OddNumbers(numbers);
        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers: ");
            IEnumerable<int> oddNumbersList = from number in numbers where number % 2 != 0 select number;
            Console.WriteLine(oddNumbersList);
            foreach (var i in oddNumbersList)
            {
                Console.WriteLine(i);
            }
        }
        
    }
        
}




    

