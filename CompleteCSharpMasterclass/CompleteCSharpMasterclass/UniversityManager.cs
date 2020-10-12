using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CompleteCSharpMasterclass
{
    public class UniversityManager
    {
        public List<University> universitiesList;
        public List<Student> studentsList;

        //Constructor
        public UniversityManager()
        {
            universitiesList = new List<University>();
            studentsList = new List<Student>();

            //Let's add some Universities
            universitiesList.Add(new University {Id = 1, Name = "Yale"});
            universitiesList.Add(new University {Id = 2, Name = "Beijing Tech"});

            //Let's add some Students
            studentsList.Add(new Student {Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1});
            studentsList.Add(new Student {Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1});
            studentsList.Add(new Student {Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2});
            studentsList.Add(new Student {Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2});
            studentsList.Add(new Student {Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2});
            studentsList.Add(new Student {Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2});
        }

        //male student method

        public void ShowMaleStudents()
        {
            IEnumerable<Student> maleStudentList =
                from student in studentsList where student.Gender == "male" select student;
            Console.WriteLine("Male students: ");
            foreach (Student student in maleStudentList)
            {
                student.GetInfo();
            }

        }
        public void ShowFemaleStudents()
        {
            IEnumerable<Student> femaleStudentList =
                from student in studentsList where student.Gender == "female" select student;
            Console.WriteLine("Female students: ");
            foreach (Student student in femaleStudentList)
            {
                student.GetInfo();
            }

        }
    }
}