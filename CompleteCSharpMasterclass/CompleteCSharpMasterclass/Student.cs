using System;

namespace CompleteCSharpMasterclass
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        
        //Foreign key
        public int UniversityId { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Student: {Name} with ID: {Id}, Gender {Gender}, age: {Age}, University ID: {UniversityId}.");
        }
    }
}