using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinq
{
    
    class Demo12
    {
        static void Main()
        {
            // Student collection
            List<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
    };

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;
            // LINQ Method Syntax to find out teenager students
            var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20);
            Student[] teenAge = studentList.Where(s => s.Age > 20).ToArray();
            List<Student>teenAges = studentList.Where(s => s.Age > 20).ToList();
                                             
        }
    }
}
