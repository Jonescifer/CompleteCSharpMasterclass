using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {

        private static void Main(string[] args)
        {
            /*
            new Thread (() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();
            new Thread (() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();
            new Thread (() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();
            new Thread (() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();
            */
            
            Enumerable.Range (0,1000).ToList().ForEach(f =>
            { 
                new Thread(() =>
                {
                    Console.WriteLine($"thread number{Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"thread number{Thread.CurrentThread.ManagedThreadId} ended");
                }).Start();
            });
            
        }
    }
}




    

