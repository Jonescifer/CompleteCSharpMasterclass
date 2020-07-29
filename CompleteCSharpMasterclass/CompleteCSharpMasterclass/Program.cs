using System;

namespace CompleteCSharpMasterclass
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                float devidedNumber = num1 / num2;
                Console.WriteLine(devidedNumber);

            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException!!!!!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException number too long or short!!!!!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cant devide by zero!");
                throw;
                
               
            }
            finally
            {
                Console.WriteLine("this is called anyways");
            }
            
        }
        
    }
}
