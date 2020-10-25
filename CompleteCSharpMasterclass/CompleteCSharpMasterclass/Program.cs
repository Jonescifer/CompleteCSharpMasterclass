using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace CompleteCSharpMasterclass
{
    class MainClass
    {
        
        private static void Main(string[] args)
        {
            string studentsXML = 
                        @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <Semester>1</Semester>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                                <Semester>4</Semester>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <Semester>3</Semester>
                            </Student>
                            <Student>
                                <Name>Frank</Name>
                                <Age>25</Age>
                                <University>Beijing Tech</University>
                                <Semester>10</Semester>
                            </Student>
                        </Students>";
            
            XDocument studentsXDocument;
            studentsXDocument = XDocument.Parse(studentsXML);

            var studentsIe = from student in studentsXDocument.Descendants("Student")
                select new
                {
                    Name = student.Element("Name")?.Value,
                    Age = student.Element("Age")?.Value,
                    Univerity = student.Element("University")?.Value,
                    Semester = student.Element("Semester")?.Value
                };

            foreach (var student in studentsIe)
            {
                Console.WriteLine($"Student: {student.Name}; of age {student.Age}; from university {student.Univerity}; semester: {student.Semester}");
            }

            Console.WriteLine();
            Console.WriteLine("arranged by age:");
            
            var sortedStudents = from student in studentsIe orderby student.Age select student;
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Student: {student.Name}; of age {student.Age}; from university {student.Univerity}; semester: {student.Semester}");
            }
                        
            
        }
    }
}




    

