using System;

namespace OperatorsC
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            
            string newUsername = "";
            string newPassword = "";
            string username = "";
            string password = "";
            
            
            Console.WriteLine("Registration screen.");
            Console.WriteLine("Enter new Username: ");
            newUsername = Console.ReadLine();
            Console.WriteLine("Enter new Password: ");
            newPassword = Console.ReadLine();
            
            if (newUsername == "" || newPassword == "")
            {
                Console.WriteLine("username or password cant be empty!");
            }
            else
            {
                Console.WriteLine("Login screen. ");
                Console.WriteLine("Enter Username: ");
                username = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                password = Console.ReadLine();
                
                if (username == "" || password == "")
                {
                    Console.WriteLine("username or password cant be empty!");
                }
                else if (username == newUsername && password == newPassword)
                {
                    Console.WriteLine("welcome {0}", username);
                }
                else
                {
                    Console.WriteLine("Wrong username/password combination, you are an idiot stimpy!");
                }
            }
            
        }
    }
}
