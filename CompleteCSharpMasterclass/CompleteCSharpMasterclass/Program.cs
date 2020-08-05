using System;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Runtime.Remoting.Messaging;

namespace CompleteCSharpMasterclass
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,,] array3D =
            {
                {
                    {10,58},
                    {27,74},
                    {54,19}
                },
                {
                    {5,59},
                    {32,34},
                    {89,62}
                }
            };

            // Depth->Row->column
            Console.WriteLine("value is: {0}", array3D[1,0,1]);

            string[,] stringArray2D = 
            {
                {"one", "two"}, 
                {"three", "four"}, 
                {"five", "six"}
            };
            stringArray2D.SetValue("chicken",1,1);
            Console.WriteLine("value is: {0}", stringArray2D[1,1]);
            stringArray2D[1, 1] = "pickem";
            Console.WriteLine("value is: {0}", stringArray2D[1,1]);
            //rank returns dimensions number of array
            Console.WriteLine("number of dimensions for array3D is {0}" , array3D.Rank );
        }
    }
}


