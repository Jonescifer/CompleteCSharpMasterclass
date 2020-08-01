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

        public Human(string firstName , string lastName, string eyeColor, byte age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }
        public void IntroduceMyself()
        {
            if (age < 2)
            {
                Console.WriteLine("Hy, I'm {0} {1}, {2} eyes, {3} year old." , firstName , lastName , eyeColor , age);
            }
            else
            {
                Console.WriteLine("Hy, I'm {0} {1}, {2} eyes, {3} years old." , firstName , lastName , eyeColor , age);
            }
            
        }
    }
}