using System;
using System.Linq;
using System.Threading;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {

        private static void Main(string[] args)
        {
            //main thread started
            Console.WriteLine("Main Thread started");
            //initialize two threads and adding the function methods as DELEGATES.. they dot have parenthesis..
            var thread1 = new Thread(Thread1Function);
            var thread2 = new Thread(Thread2Function);
            //execute the threads.
            thread1.Start();
            thread2.Start(); 
            //block Main thread from stopping while this thread runs!!!!!(Blocks the calling thread until the thread represented by this instance terminates.)
            thread1.Join();
            Console.WriteLine("Thread1Function ended");
            //block Main thread from stopping while this thread runs!!!!!
            thread2.Join();
            Console.WriteLine("Thread2Function ended");
            
            Console.WriteLine("Main Thread ended"); //Main threads ends.. no more line of code..
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
        }
        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
}
}




    

