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
            UniversityManager um = new UniversityManager();
            um.GetMaleStudents();
            um.GetFemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            um.StudentAndUniversityNameCollection();

            /*
            //sorting using an IEnumerable.
            int[] someInts = {30, 12, 4, 3, 12};
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            //sorting by using method Reverse of IEnumerable.
            IEnumerable<int> reversedInts = sortedInts.Reverse();
            foreach (var i in reversedInts)
            {
                Console.WriteLine(i);
            }
            
            //sorting using 'descending'/'ascending'
            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            foreach (var i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }
            
            um.GetStudentsFromUni();
            Console.WriteLine("please enter university id: ");
            string input = Console.ReadLine();
            try
            {
                int inputAsInt  = Convert.ToInt32(input);
                um.AllStudentsFromThatUni(inputAsInt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            */


        }
    }
}




    

