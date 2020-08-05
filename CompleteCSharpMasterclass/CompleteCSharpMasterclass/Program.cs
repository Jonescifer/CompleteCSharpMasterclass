using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Box boxDefault = new Box();
            Box box = new Box(2,3,5);
            box.DisplayInfo();
            Console.WriteLine("box Width is {0}", box.Width);
            box.Width = 100;
            Console.WriteLine("box Width is {0}", box.Width);
            Console.WriteLine("box Volume is {0}", box.Volume);
            Console.WriteLine("front surface is {0}" , box.FrontSurface);
            
        }
    }
}
