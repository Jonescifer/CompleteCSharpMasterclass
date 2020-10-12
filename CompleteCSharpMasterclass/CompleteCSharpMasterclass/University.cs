using System;

namespace CompleteCSharpMasterclass
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"University{Name} with ID number: {Id}");
        }
    }
}