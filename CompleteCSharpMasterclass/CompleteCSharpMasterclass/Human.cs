using System;

namespace CompleteCSharpMasterclass
{
    
    //This Classs is a blueprint for a datatype     
    public class Human
    {
        //member variables
        private string firstName;
        private string lastName;
        private string eyeColor;
        private byte age;
        
        
        //default constructor
        public Human()
        {
            Console.WriteLine("default constructor, object(instance of class human) created");
        }
        
        public Human(string firstName)
        {
            this.firstName = firstName;
        }
       
        public Human(string firstName , string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        //parameterised constructor without age
        public Human(string firstName , string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, byte age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //parameterised constructor with age
        public Human(string firstName , string lastName, string eyeColor, byte age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }
        public void IntroduceMyself()
        {
            if (age != 0 && firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine("hi, I'm {0} {1}, {2} eyes, {3}." , firstName , lastName , eyeColor, age);
            }
            else if (firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine("hi, I'm {0} {1}, {2} eyes." , firstName , lastName, eyeColor);
            }
            else if (firstName != null && lastName != null && age != 0)
            {
                Console.WriteLine("hi, I'm {0} {1}, {2}." , firstName , lastName, age);
            }
            else if (firstName != null && lastName != null)
            {
                Console.WriteLine("hi, I'm {0} {1}." , firstName , lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("hi, I'm {0}." , firstName);
            }
            
        }
    }
}