using System;

namespace CompleteCSharpMasterclass
{
    public class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss()
        {

        }

        public Boss(string sureName, string firstName, int salary, string companyCar)
        {
            this.SureName = sureName;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"My name is {FirstName} {SureName}, and i am your boss. to prove it, I have a {CompanyCar} company car all for me! muahahahahahahhahaha"; //instead of using string.Format("blah blah");
        }
    }
}