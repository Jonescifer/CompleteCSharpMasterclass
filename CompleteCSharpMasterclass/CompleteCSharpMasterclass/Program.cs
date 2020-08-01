using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // creat an instance of Class Human
            Human paul = new Human("Paul" , "Wolf", "Blue",41);
            Human Reut = new Human("Reut" , "Mey-Raz" , "Brown",1);

            /*
            //access public variable and change it.
            paul.firstName = "Paul";
            paul.lastName = "Wolf";
            */
            
            //call method of the Class
            paul.IntroduceMyself();
            Reut.IntroduceMyself();
           
            
            
        }
    }
}
