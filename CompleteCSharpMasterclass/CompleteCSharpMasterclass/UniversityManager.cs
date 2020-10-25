using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CompleteCSharpMasterclass
{
    class UniversityManager
    {
        public List<University> universitiesList;
        public List<Student> studentsList;

        //Constructor
        public UniversityManager()
        {
            universitiesList=new List<University>();
            studentsList=new List<Student>();
            
            //Let's add some Universities
            universitiesList.Add(new University {Id = 1, Name = "Yale"});
            universitiesList.Add(new University {Id = 2, Name = "Beijing Tech"});
            universitiesList.Add(new University{Id = 3, Name = "Bezalel"});

            //Let's add some Students
            studentsList.Add(new Student {Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1});
            studentsList.Add(new Student {Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1});
            studentsList.Add(new Student {Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2});
            studentsList.Add(new Student {Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2});
            studentsList.Add(new Student {Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2});
            studentsList.Add(new Student {Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2});
            studentsList.Add(new Student{Id = 7,Name = "Jack", Gender = "male",Age = 41,UniversityId = 3});

        }

        public void GetMaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in studentsList where student.Gender == "male" select student;
            Console.WriteLine("Male students: ");
            foreach (Student student in maleStudents)
            {
                student.GetInfo();
            }
        }

        public void GetFemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in studentsList where student.Gender == "female" select student;
            Console.WriteLine("Female students: ");
            foreach (Student student in femaleStudents)
            {
                student.GetInfo();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in studentsList orderby student.Age select student;
            Console.WriteLine("Students sorted by age: ");
            foreach (var student in sortedStudents)
            {
                student.GetInfo();
            }
        }

        public void AllStudentsFromBeijingTech()
        {

            var bjtStudents = from student in studentsList join university in universitiesList on student.UniversityId equals university.Id where university.Name == "Beijing Tech" select student;
            Console.WriteLine("Students from Beijing: ");
            foreach (var student in bjtStudents)
            {
                student.GetInfo();
            }
        }

        public void AllStudentsFromThatUni(int id)
        {
            IEnumerable<Student> myStudents = from student in studentsList
                join university in universitiesList on student.UniversityId equals university.Id
                where university.Id == id
                select student;
            Console.WriteLine($"Students from univerity: {id} ");
            foreach (var student in myStudents)
            {
                student.GetInfo();
            }
            
        }

        public void GetStudentsFromUni()
        {
            int numVal;
            Console.WriteLine("please enter university id: ");
            string input = Console.ReadLine();
            try
            { 
                numVal = Convert.ToInt16(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            IEnumerable<Student> studentUniversityId = from student in studentsList where student.UniversityId == numVal select student;

            foreach (var student in studentUniversityId)
            {
                student.GetInfo();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in studentsList
                join university in universitiesList on student.UniversityId equals university.Id
                orderby student.Name
                select new {StudentName = student.Name, UniversityName = university.Name};

            Console.WriteLine("New Collection: ");
            foreach (var col in newCollection)
            {
                Console.WriteLine($"Student: {col.StudentName} in university: {col.UniversityName}.");
            }
        }

        
        
        
    }
}