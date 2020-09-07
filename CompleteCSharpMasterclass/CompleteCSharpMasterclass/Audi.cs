using System;

namespace CompleteCSharpMasterclass
{
    //an Audi is a Car 
    public class Audi : Car
    {
        private string Model { get; set; }
        private string _brand = "Audi";
        
        public Audi (int hp , string color ,string model) : base ( hp , color) //have to have arguments horsePower/color but it will take the parameters from base class.
        {
            this.Model = model;
        }
        
        public new void ShowDetails()
        {
            Console.WriteLine("Brand "  + _brand + ", Model " + Model + ", HP " + Hp + ", color " + Color);
        }

        public override void Repair()
        {
            Console.WriteLine("Audi {0} was repaired!", Model);
        }
    }  
}