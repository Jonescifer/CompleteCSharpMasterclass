using System;

namespace CompleteCSharpMasterclass
{
    public class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            this.Radius = radius;
        }
        
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThis sphere has a radius of: {Radius} ");
        }
        
        public override double GetVolume()
        {
            
            return 4 / 3*(Math.PI)*(Math.Pow(Radius, 3));
            
        }
    }
}