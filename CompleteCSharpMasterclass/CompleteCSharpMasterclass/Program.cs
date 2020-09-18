using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CompleteCSharpMasterclass
{
    internal class MainClass
    {
        private static void Main(string[] args)
        {
            Shape[] shapeArray = {new Sphere(4), new Cube(3)};

            foreach (var shape in shapeArray)
            {

                Console.WriteLine($"\nThis is a {shape.GetInfo()} and it's volume is {shape.GetVolume()}.\n");
                
                var aCube = shape as Cube;
                if (aCube == null)// you could use if (!(shape is Cube)) without applying null to a new shape..
                {
                    Console.WriteLine("NO! This Shape is not a cube!");
                }  
                if (shape is Cube)
                {
                    Console.WriteLine("YES! This Shape is cube!");
                }
            }
            object cube1 = new Cube(7);
            var cube2 = (Cube) cube1;
            Console.WriteLine($"\n{cube2.Name} has a volume of {cube2.GetVolume()}");
        }
    }
        
}




    

