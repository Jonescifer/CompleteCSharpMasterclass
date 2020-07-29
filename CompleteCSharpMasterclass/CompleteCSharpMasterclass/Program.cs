using System;

namespace OperatorsC
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            CheckTemperture(AskUser());
        }

        static int AskUser()
        {
            Console.WriteLine("please enter temperature outside!");
            int inputTemperature = int.Parse(Console.ReadLine());
            return inputTemperature;
        }
        
        static void CheckTemperture(int temperture)
        {
            
            if (temperture < 20)
            {
                Console.WriteLine("stay home");
            }
            else if (temperture == 20)
            {
                Console.WriteLine("put coat and go outside");
            }
            else
            {
                Console.WriteLine("Go to the Beach");
            }
                
        }
        
    }
}
