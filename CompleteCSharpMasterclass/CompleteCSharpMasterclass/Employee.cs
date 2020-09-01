using System;

namespace CompleteCSharpMasterclass
{
    public class Employee
    {
        public  string SureName { get; set; }
        public  string FirstName { get; set; }
        public  int Salary { get; set; }

        public Employee()
        {
            this.SureName = "Default surename";
            this.FirstName = "Defaul firstname";
            this.Salary = 20000;
        }
        public Employee(string sureName , string firstName , int salary )
        {
            this.SureName = sureName;
            this.FirstName = firstName;
            this.Salary = salary;
        }
        

        
        
        public virtual void Work()
        {
            //throw new NotImplementedException();
            Console.WriteLine("My name is {0} {1} and I am working!",FirstName, SureName);
        }

        public void Pause()
        {
            //throw new NotImplementedException();
            Console.WriteLine("My name is {0} {1} and I am having a break!",FirstName, SureName);
        }
    }
    
}