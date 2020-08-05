using System;

namespace CompleteCSharpMasterclass
{
    public class Box
    {
        //member variables
        private int _length;
        private int _height;
        //private int width;
        private int _volume;

        public Box()
                {
                    Console.WriteLine("A new default box was created!");
                    _length = 1;
                    Width = 1;
                    _height = 1;
                    Console.WriteLine("Volume is: {0}" , Volume);
                }

        public Box (int height , int width , int length)
                {
                    this._length = length;
                    this._height = height;
                    Width = width;
                }

        public  int FrontSurface
        {
            get
            {
                return Width * _length;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                {
                    _height = -value;
                }
                else
                {
                    _height = value;
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
                return this.Height*this._length*this.Width;
            }
            
        }

        

            public void DisplayInfo()
        {
            Console.WriteLine("Height {0} Width {1} Length {2} volume is {3}", Height, Width, _length, Volume);
        }
    }
}