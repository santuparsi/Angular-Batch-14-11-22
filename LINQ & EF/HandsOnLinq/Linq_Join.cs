using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinqtoObjects
{
    class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student1(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    class Enroll
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public Enroll(int id, string name)
        {
            this.Id = id;
            this.CourseName = name;
        }
    }
    class StudentEnroll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public StudentEnroll(int id, string name,
        string cname)
        {
            this.Id = id;
            this.Name = name;
            this.CourseName = cname;
        }
    }
    class Linq_Join
    {
        static void Main(string[] args)
        {
            //student details
            Student1[] students = { new Student1(1,
"Hari"), new Student1(2, "Ravi"), new Student1(3,
"Narender"), new Student1(4, "Sandeep") };
            //enroll details
            Enroll[] enrollments = { new Enroll(1,
".NET"), new Enroll(2, "SAP"), new Enroll(3, "SAP"), new
Enroll(4, "SAP") };
            var join = from s in students
                       join e in enrollments on s.Id equals e.Id
                      
                       select new StudentEnroll(s.Id, s.Name, e.CourseName);
             join = from s in students
                       join e in enrollments on s.Id equals e.Id
                       where e.CourseName == "SAP"
                       select new StudentEnroll(s.Id, s.Name, e.CourseName);
            foreach (var ex in join)
            {
                Console.WriteLine(ex.Name + ":" + ex.CourseName);
            }
            Console.WriteLine();
            var join1 = from s in students
                        join e in enrollments on s.Id equals e.Id
                        select new { ID = s.Id, Name = s.Name, CName = e.CourseName } into es
                        group es by es.CName;
            foreach (var ex in join1)
            {
                Console.WriteLine(ex.Key);
                foreach (var e in ex)
                {
                    Console.WriteLine(e.Name);
                }
            }
            Console.Read();
        }
    }
}