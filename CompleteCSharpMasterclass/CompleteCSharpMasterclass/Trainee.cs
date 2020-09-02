using System;

namespace CompleteCSharpMasterclass
{
    public class Trainee : Employee
    {
        public double WorkingHours { get; set; }
        public double SchoolHours { get; set; }
        
        public Trainee(string sureName, string firstName, int salary, double workingHours, double schoolHours): base (sureName, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public override void Work()
        {
            Console.WriteLine("My name is {0} {1} and I am working {2} hours a day.", FirstName, SureName, this.WorkingHours);
        }

        public void Learn()
        {
            Console.WriteLine("My name is {0} {1} and I am learnig at school {2} hours a day.", FirstName, SureName, this.SchoolHours);
        }
    }

}