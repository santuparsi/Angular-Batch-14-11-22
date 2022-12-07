using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinq
{
    internal class Demo9
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
    };
            //fetch student with age>18
            var result = from s in studentList
                         where s.Age > 18
                         select s;
            //display data assending order of Student Name
            result = from s in studentList
                     where s.Age > 18
                     orderby s.StudentName ascending
                     select s;
            //display student with id=2
            result = from s in studentList
                     where s.StudentID==2
                     select s;
            foreach (var item in result)
                Console.WriteLine($"ID:{item.StudentID} Name:{item.StudentName} Age:{item.Age}");

        }
    }
}
