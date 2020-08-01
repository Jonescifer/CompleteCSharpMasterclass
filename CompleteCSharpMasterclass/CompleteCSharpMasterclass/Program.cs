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
            Human maul = new Human("maul" , "rolf", "grey");
            Human saul = new Human("saul" , "dolf");
            Human laul = new Human("laul");
            Human kaul = new Human("kaul" , "lolf",41);
            Human defaulHuman = new Human();
            /*
            //access public variable and change it.
            paul.firstName = "Paul";
            paul.lastName = "Wolf";
            */
            
            //call method of the Class
            paul.IntroduceMyself();
            maul.IntroduceMyself();
            saul.IntroduceMyself();
            laul.IntroduceMyself();
            kaul.IntroduceMyself();



        }
    }
}
