using System;

namespace CompleteCSharpMasterclass
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number! ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = Int16.Parse(userInput);
            }
            catch (FormatException e1)
            {
                Console.WriteLine("FormatException!!!!! {0}", e1);
            }
            catch (OverflowException e2)
            {
                Console.WriteLine("OverflowException number too long or short!!!!! {0}", e2);
            }

            catch (ArgumentNullException e3)
            {
                Console.WriteLine("Argument NULL exception {0}", e3);
            }
            finally
            {
                Console.WriteLine("this is called anyways");
            }

            Console.ReadKey();

        }
    }
}
