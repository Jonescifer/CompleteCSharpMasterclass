using System;
using System.Linq;
using System.Threading;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {

        private static void Main(string[] args)
        {
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread X");
            }){IsBackground = true}.Start();
            
            Console.WriteLine("Started");
            Enumerable.Range (0,1000).ToList().ForEach(f =>
            {
                Console.WriteLine($"loop: {f}");
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    try
                    {
                        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                        Thread.Sleep(1000);
                        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                });
            });
            Console.WriteLine("Ended");
            //Console.ReadLine();
        }
    }
}




    

