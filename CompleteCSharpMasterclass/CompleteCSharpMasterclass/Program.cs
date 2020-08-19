﻿using System;
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
            int [][] jaggedArray = new int[3][]; //new jagged array of type int. has three values. at indexs: 0,1,2.
            jaggedArray[0]= new int[5];// new array at index 0. has five values.
            jaggedArray[0][3] = 66;// added the value 66 to the 4th place (index 3) of the array we just created one line up.
            // hope i got it right :)
            
            
            int[] studentsGrades = new[] {40, 55, 100, 98, 75, 34, 29, 89, 99,45,98};
            var studentsAvarage = GetAverage(studentsGrades);
            foreach (var grade in studentsGrades)
            {
                Console.WriteLine("grade {0}" , grade);
            }
            
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



    

