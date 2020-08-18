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
            int[] studentsGrades = new[] {40, 55, 100, 98, 75, 34, 29, 89, 99,45,98};
            var studentsAvarage = GetAverage(studentsGrades);
            
            Console.WriteLine("average of grades is: {0}", studentsAvarage);
        }

        static double GetAverage(int [] gradesArray)
        {
            double average = 0;
            int sum = 0;
            int size = gradesArray.Length;
            for (int i = 0 ; i < size ; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size; //casting sum to double!
            
            return average;
        }
    }
}



    

