using System;
using System.CodeDom;
using System.Collections.Generic;
namespace CompleteCSharpMasterclass

{ 
    class MainClass
    {
        static void Main(string[] args)
        {
          var n1 = new Notification("connor", "he is comming","1986" );
          var n2 = new Notification("terminator", "astalavista baby", "1986");
          n1.ShowNotification();
          n2.ShowNotification();
        }
    }
}



    

