using System;

namespace CompleteCSharpMasterclass
{
    public class Box
    {
        //member variables
        private int length = 1;
        private int height = 1;
        private int width = 1;
        private int volume;

        private void SetLength(int length)
        {
            this.length = length;
        }
        
        public void SetHeight(int height)
        {
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
        public void DisplayInfo()
        {
            Console.WriteLine("Length {0} height {1} width {2} volume is {3}", length, height, width, volume = length*height*width);
        }
    }
}