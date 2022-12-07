using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinq
{
    class OrderByDemo
    {
       static void Main()
        {
            IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
};

            var orderByResult = from s in studentList
                                orderby s.StudentName
                                select s;

            var orderByDescendingResult = from s in studentList
                                          orderby s.StudentName descending
                                          select s;
           //Method Syntax
            var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);
            var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);
           //Multiple Sorting
           var orderByResult1 = from s in studentList
                   orderby s.StudentName, s.Age 
                   select new { s.StudentName, s.Age };


        }
    }
}
