using System;

namespace CompleteCSharpMasterclass
{
    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"University {Name} with ID {Id}");
        }
    }
}