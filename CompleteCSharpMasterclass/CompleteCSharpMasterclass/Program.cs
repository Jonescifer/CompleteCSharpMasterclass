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
            string firstInput;
            string secondInput; 
            int intFirstInput;
            int intSecondInput;
            string[] stringArray;
            
            Console.WriteLine("Enter value here: ");
            firstInput = Console.ReadLine();
            
            Console.WriteLine("Select the Data type to validate the input you have entered.");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer.");
            Console.WriteLine("Press 3 for Boolean.");
            
            secondInput = Console.ReadLine();
            
            
            
            bool isValidInteger = int.TryParse(secondInput , out intSecondInput);
            
            switch (intSecondInput)
            {
                case 1:
                {
                    if (IsValidString(firstInput))
                    {
                        Console.WriteLine("You have entered a string value: {0}." , firstInput);
                        
                    }
                    else
                    {
                        Console.WriteLine("You have entered an invalid string value: {0}." , firstInput);
                     
                    }
                    break;
                }
                case 2:
                {
                    if (int.TryParse(firstInput , out intFirstInput))
                    {
                        Console.WriteLine("You have entered an integer: {0}." , firstInput);
                    }
                    Console.WriteLine("You have entered an invalid integer: {0}." , firstInput);
                    break;
                }
                case 3:
                {
                    if (firstInput == secondInput)
                    {
                        Console.WriteLine("first string: {0}, second string {1}, Strings match!", firstInput , secondInput);
                    }
                    else
                    {
                        Console.WriteLine("first string: {0}, second string {1}, Strings don't match.", firstInput , secondInput);
                    }
                    break;
                }
                        
            }



            static bool IsValidString(string input)
            {
                foreach (char c in input)
                {
                    if (char.IsNumber(c))
                    {
                        return false;
                        break;
                    }
                }
                return true;
            }
        }
    }
}

