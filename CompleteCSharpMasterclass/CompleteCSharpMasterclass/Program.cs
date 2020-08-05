using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class Program
    {
        public static void Main(string[] args)
        {
            //declare and initialize array of integers.
            int[] grades = new int [5];
            grades[0] = 1;
            grades[1] = 20;
            grades[2] = 2;
            grades[3] = 5;
            grades[4] = 18;

            Console.WriteLine("grades at index 2 is: {0}" , grades[2]);
            
            //assign value to aray at index 2
            string input = Console.ReadLine();
            grades[2] = int.Parse(input);
            Console.WriteLine("grades at index 2 is: {0}" , grades[2]);
            
            //another way of initializing an array
            int[] gradesOfMathStudentsA = { 1,5,7,13,18,10 };
            
            //third way of initializing an array
            int[] gradesOfMathStudentsB = new int[]{5,6,3,18,19,1};

            Console.WriteLine("legnth of MathStudentA array is {0}" , gradesOfMathStudentsA.Length);
        }
    }
}
