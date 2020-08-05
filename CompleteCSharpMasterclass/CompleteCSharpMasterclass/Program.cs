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
            string inputValue;
            string inputValueType;
            bool valid = false;
            
            Console.WriteLine("Enter value here: ");
            inputValue = Console.ReadLine();
            
            Console.WriteLine("Select the Data type to validate the input you have entered.");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer.");
            Console.WriteLine("Press 3 for Boolean.");
            
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    //check for string
                    valid = IsValidString(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int returnValue = 0;
                    //check for integer
                    valid = int.TryParse(inputValue, out returnValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool returnFlag = false;
                    //check for boolean
                    valid = bool.TryParse(inputValue, out returnFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "Unknown";
                    Console.WriteLine("Unable to detect input type! ERROR!!!!!!!!!!!!");
                    break;
            }

            Console.WriteLine("Inputted value is {0} ", inputValue);
            if (valid)
            {
                Console.WriteLine("It's a valid {0}" , inputValueType);
            }
            else
            {
                Console.WriteLine("It's an invalid {0}" , inputValueType);
            }



            static bool IsValidString(string value)
            {
                foreach (char c in value)
                { 
                    if (!char.IsLetter(c)) 
                        return false;
                }
                return true;
            }
        }
    }
}

