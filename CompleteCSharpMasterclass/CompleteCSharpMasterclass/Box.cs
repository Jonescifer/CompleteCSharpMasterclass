using System;

namespace CompleteCSharpMasterclass
{
    public class Box
    {
        //member variables
        private int length;
        private int height;
        //private int width;
        private int volume;

        public Box()
                {
                    Console.WriteLine("A new default box was created!");
                    length = 1;
                    Width = 1;
                    height = 1;
                    Console.WriteLine("Volume is: {0}" , Volume);
                }

        public Box (int height , int width , int length)
                {
                    this.length = length;
                    this.height = height;
                    Width = width;
                }

        public  int FrontSurface
        {
            get
            {
                return Width * length;
            }
        }
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

        public int Width { get; set; }

        //the line above (short version of making a property) the lines below - long version of making a property, BUT it needs a member variable e.g. int height... where the short one doesnt need a member variable:

        /*
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                this.width = value;
            }
        }

        public void SetLength(int length)
        {
            this.length = length;
        }
        */

        public int Volume
        {
            get
            {
                return this.Height*this.length*this.Width;
            }
            
        }

        

            public void DisplayInfo()
        {
            Console.WriteLine("Height {0} Width {1} Length {2} volume is {3}", Height, Width, length, Volume);
        }
    }
}