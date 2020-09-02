using System;

namespace CompleteCSharpMasterclass
{
    //a BMW is a Car 
    public class Bmw : Car
    {
        protected string Model { get; set; }
        private string _brand = "BMW";

        public Bmw()
        {
            
        } 
        
        public Bmw (int hp , string color ,string model) : base ( hp , color) //have to have arguments horsePower/color but it will take the parameters from base class.
        {
            this.Model = model;
        }
        
        public new void ShowDetails()
        {
            Console.WriteLine(Model + " " + _brand + " " + "HorsePower " + Hp + ", Color " + Color + ".");
        }

        //added SEALED to the method so it cannot be over ridden by the derived class M3.
        public sealed override void Repair() 
        {
            Console.WriteLine("BMW {0} was repaired!", Model);
        }
    }
}