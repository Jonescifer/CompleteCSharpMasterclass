using System;

namespace CompleteCSharpMasterclass
{
    public class Car
    { 
        protected int Hp { get; set; }
        protected string Color { get; set; }
        
        public Car()
        {
            Hp = 120;
            Color = "Brown";
        }
        
        public Car(int hp , string color )
        {
            this.Hp = hp;
            this.Color = color;
        }
        public void ShowDetails()
        {
            Console.WriteLine("HorsePower " + Hp + ", Color " + Color + ".");
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
        
    }
    
}