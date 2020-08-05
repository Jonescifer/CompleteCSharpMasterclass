using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(true);
            //member1.SharingPrivateInfo(); //private method
            
            
        }
    }
}
