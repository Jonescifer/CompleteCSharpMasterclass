using System;
using System.Collections;
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
            //declaring an ArrayList with an undefined amount of objects.
            ArrayList myArrayList = new ArrayList();
            //declaring an ArrayList and initializing it with a defined amount of objects.(100)
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);//
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);//
            myArrayList.Add(128);//
            myArrayList.Add(25.3);//
            myArrayList.Add(13);

            
            // remove an element with a specific value. the first "13" object it encounters
            myArrayList.Remove(13);
            myArrayList.Remove(13);
            myArrayList.Remove(13);//didnt find anything so nothing changed in the sum.
            myArrayList.RemoveAt(0);
            Console.WriteLine(myArrayList.Count);

            double sum = 0;
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
        }

    }
}



    

