using System;

namespace CompleteCSharpMasterclass
{
    internal class MainClass
    {

        public delegate double Calculate(double x, double y);

        public static double Add(double a, double b)  
        {
            Console.WriteLine("x+y equals to: " + (a+b));
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            Console.WriteLine("x-y equals to: " + (a-b));
            return a - b;
        }
        public static double Devide(double a, double b)
        {
            Console.WriteLine("x/y equals to: " + (a/b));
            return a/b;
        }
        
        private static void Main(string[] args)
        {
            Calculate getSum = Add;
            Calculate getQuotient = Devide;
            //getSum(5.0,6.0);
            //getQuotient(4.0, 3.0);
            Calculate multiCalc = getSum + getQuotient; // because we cannot use Add + Devide - we can combine methods like this.
            multiCalc += Subtract;//added a method.
            multiCalc -= getSum;// reduce a delegate.
            multiCalc(6.0, 8.0);
            

        }
    }
        
}




    

