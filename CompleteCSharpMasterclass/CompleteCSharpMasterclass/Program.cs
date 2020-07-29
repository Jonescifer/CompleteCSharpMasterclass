using System;

namespace OperatorsC
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            //unary operators
            int num1 = 5;
            int num2 = 3;
            int num3 = -num1;
            Console.WriteLine("num3 is: {0}",num3);
            Console.WriteLine("num1 is: {0}",num1);
            Console.WriteLine("num2 is: {0}",num2);

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}" , !isSunny);
            
            //increment operators
            
            int num = 0;
            num++;
            Console.WriteLine("the number is: {0}", num);
            Console.WriteLine("the number is: {0}", num++); // post increment
            Console.WriteLine("the number is: {0}", ++num); //pre increment
            
            //decrement
            num--;
            Console.WriteLine("the number is: {0}", num);
            Console.WriteLine("the number is: {0}", num--); // post deccrement
            Console.WriteLine("the number is: {0}", --num); //pre deccrement

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is : {0}", result);
            
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is : {0}", result);
            
            result = num1 / num2;
            Console.WriteLine("result of num1 divided by num2 is : {0}", result);
            
            result = num1 * num2;
            Console.WriteLine("result of num1 multiplied num2 is : {0}", result);
            
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is : {0}", result);
            
            bool isLower = num1 < num2;
            Console.WriteLine("num1 < num2 is : {0}", isLower);
            
            bool isEqual = num1 == num2;
            Console.WriteLine("num1 equals num2 is : {0}", isEqual);
            
            bool isNotEqual = num1 != num2;
            Console.WriteLine("num1 Not equals num2 is : {0}", isNotEqual);

            bool isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("is it lower and sunny? : {0}", isLowerAndSunny);

            bool isLowerOrSunny = isLower || isSunny;
            Console.WriteLine("is it lower or sunny? : {0}", isLowerOrSunny);

        }
        
    }
}
