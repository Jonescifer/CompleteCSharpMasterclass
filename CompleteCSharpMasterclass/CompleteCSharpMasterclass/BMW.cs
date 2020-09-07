using System;

namespace CompleteCSharpMasterclass
{
    //a BMW is a Car 
    public class Bmw : Car
    {
        
        private string _brand = "BMW";
        protected string Model { get; set; }
        public Bmw()
        {
            
        } 
        
        public Bmw (int hp , string color ,string model) : base ( hp , color) //have to have arguments horsePower/color but it will take the parameters from base class.
        {
            this.Model = model;
        }
        
        public new void ShowDetails() // new is not override, it is intended to HIDE the base class method, i.e. use instead. but not override. 
        {
            Console.WriteLine("Brand " + _brand  + ", Model " + Model + ", HP " + Hp + ", color " + Color);
        }

        //added SEALED to the method so it cannot be over ridden by the derived class M3.
        public sealed override void Repair() 
        {
            Console.WriteLine("BMW {0} was repaired!", Model);
        }
    }
}