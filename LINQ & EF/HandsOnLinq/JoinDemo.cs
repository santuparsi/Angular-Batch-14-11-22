using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinq
{
    class JoinDemo
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron"  } 
};

            IList<Standard> standardList = new List<Standard>() { 
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

            var innerJoin = from s in studentList // outer sequence
                            join st in standardList //inner sequence 
                            on s.StandardID equals st.StandardID // key selector 
                            select new
                            { // result selector 
                                StudentId=s.StudentID,
                                StudentName = s.StudentName,
                                StandardName = st.StandardName
                            };
            foreach(var item in innerJoin)
            {
                Console.WriteLine($"ID:{item.StudentId} Name:{item.StudentName} Std:{item.StandardName}");
            }
            //Method syntax
            //var innerJoin1 = studentList.Join(// outer sequence 
            //                      standardList,  // inner sequence 
            //                      student => student.StandardID,    // outerKeySelector
            //                      standard => standard.StandardID,  // innerKeySelector
            //                      (student, standard) => new  // result selector
            //                      {
            //                          StudentName = student.StudentName,
            //                          StandardName = standard.StandardName
            //                      });
        }
    }
}
