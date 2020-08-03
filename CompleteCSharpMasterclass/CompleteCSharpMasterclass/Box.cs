using System;

namespace CompleteCSharpMasterclass
{
    public class Box
    {
        //member variables
        private int length = 3;
        private int height;
        private int width;
        private int volume;

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                
            }
        }

        public void SetLength(int length)
        {
            this.length = length;
        }
        
        public void SetHeight(int height)
        {
            if (height<0)
            {
                throw new Exception("must have numbers larger than 0");
            }
            this.height = height;
        }
        
        public void SetWidth(int width)
        {
            this.width = width;
        }
        
        public int GetLength()
        {
            return this.length;
        }
        
        public int GetHeight()
        {
            return this.height;
        }
        
        public int GetWidth()
        {
            return this.width;
        }

        public int GetVolume()
        {
            return this.height * this.length * this.width;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Length {0} height {1} width {2} volume is {3}", length, height, width, volume = length*height*width);
        }
    }
}