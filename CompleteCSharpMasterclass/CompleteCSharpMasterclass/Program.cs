using System;
using System.Diagnostics.Eventing.Reader;

namespace OperatorsC
{
     class MainClass
    {
        static string newUsername = "";
        static string newPassword = "";
        static string username = "";
        static string password = "";
        
        public static void Main(string[] args)
        {
            Register();
        }

        public static void Register()
        {
            Console.WriteLine("Registration screen.");
            Console.WriteLine("Enter new Username: ");
            newUsername = Console.ReadLine();
            Console.WriteLine("Enter new Password: ");
            newPassword = Console.ReadLine();
            Console.WriteLine("Registration ended.");
            Console.WriteLine("------------------------------------");

            if (newUsername == "" || newPassword == "")
            {
                Console.WriteLine("Failed to register: username or password cant be empty!");
            }
            else
            {
                Login();
            }
        }

        public static void Login()
        {
            Console.WriteLine("Login screen. ");
            Console.WriteLine("Enter Username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            password = Console.ReadLine();
                
            if (username == "" || password == "")
            {
                Console.WriteLine("Failed to login: username or password cant be empty!");
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
