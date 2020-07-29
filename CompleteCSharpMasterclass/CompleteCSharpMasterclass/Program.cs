using System;
using System.Diagnostics.Eventing.Reader;

namespace OperatorsC
{
    class MainClass
    {
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
            username = Console.ReadLine();
            
            //check username is not empty
            if (username != "")
            {
                Console.WriteLine("Enter new Password: ");
                password = Console.ReadLine();
                 
                //check password is not empty
                if (password != "")
                {
                    Console.WriteLine("Registration ended.");
                    Console.WriteLine("------------------------------------");
                    
                    //run method Login
                    Login();
                }
                else
                {
                    Console.WriteLine("Failed to register: password cant be empty!"); 
                }
            }
            else
            {
                Console.WriteLine("Failed to register: username cant be empty!");
            }
            
        }

        public static void Login()
        {
            Console.WriteLine("Login screen. ");
            Console.WriteLine("Enter Username: ");
                        
            if (username == Console.ReadLine())
            { 
                Console.WriteLine("Enter Password: ");
                if (password == Console.ReadLine()) 
                { 
                    Console.WriteLine("Login Successful {0}!", username);
                }
                else
                { 
                    Console.WriteLine("Wrong password, you are an idiot stimpy!");
                }
            }
            else 
            { 
                Console.WriteLine("Wrong username, you are an idiot stimpy!");
            }

        }
    }
}

