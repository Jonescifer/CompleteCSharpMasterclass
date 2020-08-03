using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Box box = new Box();

            //box.length = 10;
            //box.SetLength(1);
            box.Height = 2;
            box.SetWidth(5);
            box.DisplayInfo();
        }
    }
}
