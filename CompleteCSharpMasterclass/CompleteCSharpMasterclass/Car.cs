using System;

namespace CompleteCSharpMasterclass
{
    public class Car
    { 
        protected int Hp { get; set; }
        protected string Color { get; set; }
        
        //has a relationship
        protected CarIdInfo CarIdInfo = new CarIdInfo();
        public void SetCarIdInfo(int idNum,string owner)
        {
            CarIdInfo.IdNum = idNum;
            CarIdInfo.Owner = owner;
        }
        public void GetCarIdInfo()
        {
            Console.WriteLine("cars id is {0}, and its owner is {1}", CarIdInfo.IdNum,CarIdInfo.Owner);
        }
        
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