using System;

namespace CompleteCSharpMasterclass
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        
        // Foreign Key
        public int UniversityId { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Student {Name} with ID {Id}, {Gender}, Age {Age}, from University with the ID {UniversityId}");
        }
    }
}