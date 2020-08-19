using System;
using System.Collections;
using System.Collections.Generic;
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
           //int ARRAY immutable(fixed array size) & limited to one type
           int[] array = new int[]{99,96,87,76};
           
           //____________________________________________________________________________________________________________________________________________________________________
           
           //List Object mutable!
           var list = new List <int>{1,2,3,4};
           
           list.Add(0); list.Add(32); 
           list.Sort();//sorts the list by default comparer
               
            foreach (var element in list) 
            { 
                Console.WriteLine(element);
            }

            list.RemoveRange(2,2);

            foreach (var element in list) 
            { 
                Console.WriteLine(element);
            }
            
            Console.WriteLine("is value 32 in the list? {0}", list.Contains(32));// does it contain element with value 32
            
            int index = list.FindIndex(x => x == 4); // find the index of first element that has 4.
            Console.WriteLine("index of first element that contains the value 4 is: {0}" , index);        // index of the first occurence of value 4. is index 2. third place in the list..
            Console.WriteLine("value at index {0} is {1}", index, list[index]); // value at the potion of index... value is 4 index is 2
            list.RemoveAt(index);
            list.ForEach(i => Console.WriteLine(i)); // shorter forEach loop which is a method of list!!!!!!! using lambda expression
            
            Console.WriteLine();

            var objectList = new List<object>(); // can be a list of objects!
            
            //____________________________________________________________________________________________________________________________________________________________________
            
            //ArrayList can also store objects and any datatype together.
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Two");
            arrayList.Add("3");
            arrayList.Add(new Number{N = 4} );// added new object and set the N variable to 4.

            foreach (var o in arrayList)
            {
                Console.WriteLine(o);
            }






        }

    }
    //need to create this specific class just so i can show the number 4 in the Number object.. need to create the PROPERTY to assign the value to object Number then need to 
    //create the METHOD override string to show the number as string...
    class Number// for the example of adding an object to arrayList or List
    {
        public int N { get; set; }

        public override string ToString()
        {
            return N.ToString();
        }
    }
}



    

