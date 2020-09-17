using System;

namespace CompleteCSharpMasterclass
{
    public abstract class Shape
    {
        protected string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        public abstract double GetVolume();
    }
}