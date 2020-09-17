using System;

namespace CompleteCSharpMasterclass
{
    public class Cube : Shape
    {
        private double Length { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            this.Length = length;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\n{Name}'s length is {Length}");
        }
        
        public override double GetVolume()
        {
            return Math.Pow(Length, 3);
        }
        
    }
}