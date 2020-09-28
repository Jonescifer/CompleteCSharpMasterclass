using System;

namespace CompleteCSharpMasterclass
{
    internal class MainClass
    {
        public delegate string GetTextDelegate(string name);

        public delegate double GetResultDelegate(double a, double b);
        private static void Main(string[] args)
        {
            // Creating an anonymous method or inline delegate
            GetTextDelegate getTextDelegate = delegate(string name)
            {
                return "\nHello " + name;
            };
            
            //exampleof methods that gets an anonymous method as parameter.
            Display(getTextDelegate);
            
            //Expression Lambda expression.
            GetTextDelegate getHelloTextDelegate = (string name) => { return "\nHello " + name;};
            
            //Statement Lambda expression.
            GetTextDelegate getGoodbyTextDelegate = (string name) =>
            {
                Console.WriteLine("\nI'm inside of a staement lambda.");
                return "Goodbye " + name;
            };
            
            // Lambda Expression example 1- its the short version of the code we have in line 10 - works without brackets in 'name' because its only ONE VARIABLE.
            GetTextDelegate getWelcomeTextDelegate = name => "\nWelcome! " + name; 
            
            //examples for code in lines: 21-24-31:
                        Console.WriteLine(getHelloTextDelegate("Paul."));
                        Console.WriteLine(getGoodbyTextDelegate("Paul."));
                        Console.WriteLine(getWelcomeTextDelegate("Paul."));
            //-----------------------------------------------------------------------------------------------------------------------------------------------            
            
            // Lambda Expression example 2 
            GetResultDelegate getSum = (a, b) => a + b;
            
            Console.WriteLine(getSum(5.0,9.3));
            //or with method (like u like it)
            DisplayNum(getSum);

            GetResultDelegate getProduct = (a, b) => a * b;
            DisplayNum(getProduct);
        }

        static void DisplayNum(GetResultDelegate getResultDelegate)
        {
            Console.WriteLine(getResultDelegate(4.0,2.2));
        }
        
        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("World."));
        } 
        
    }
        
}




    

