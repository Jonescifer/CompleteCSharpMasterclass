using System;
using System.CodeDom;
using System.Collections.Generic;
namespace CompleteCSharpMasterclass

{ 
    class MainClass
    {
        static void Main(string[] args)
        {
           var employee1 = new Employee("Jagger","Mick", 20000);
           employee1.Work();
           employee1.Pause();

           var employee2 = new Boss("Kushy", "Looshy", 40000, "Maserati");
           employee2.Lead();
           employee2.Work();
           employee2.Pause();
           
           var employee3 = new Trainee("Average","Joe",15000,6.5,9.5);
           employee3.Learn();
           employee3.Work();
           employee3.Pause();
        }
    }
}



    

