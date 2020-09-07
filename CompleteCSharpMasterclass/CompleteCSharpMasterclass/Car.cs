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
            Console.WriteLine("HP " + Hp + ", Color " + Color + ".");
        }
        public virtual void Repair()// virtual so i can override it in deriving classes. Polymorphism at work #2: the VIRTUAL method Repair() is invoked on each of the derived classes, not the base class... V I R T U A L
        {
            Console.WriteLine("Car was repaired!");
        }
        
    }
    
}