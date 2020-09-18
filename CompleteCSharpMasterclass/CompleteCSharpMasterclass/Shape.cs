using System;

namespace CompleteCSharpMasterclass
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public virtual string GetInfo()
        {
            return $"{Name}.";
        }

        public abstract double GetVolume();
    }
}