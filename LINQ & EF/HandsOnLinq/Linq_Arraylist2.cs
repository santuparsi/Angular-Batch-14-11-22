using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HandsOnLinqtoObjects
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Scores { get; set; }
    }
    class Linq_Arraylist2
    {
        static void Main()
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(
              new Student
              {
                  FirstName = "Rahul",
                  LastName = "Dravid",
                  Scores = new int[] { 98, 92, 81, 60 }
              });
            arrList.Add(
                new Student
                {
                    FirstName = "Sonia ",
                    LastName = "Gandhi",
                    Scores = new int[] { 75, 84, 91, 39 }
                });
            arrList.Add(
                new Student
                {
                    FirstName = "Rahul",
                    LastName = "Gandhi",
                    Scores = new int[] { 88, 94, 65, 91 }
                });
            arrList.Add(
                new Student
                {
                    FirstName = "Preethi",
                    LastName = "Nayak",
                    Scores = new int[] { 97, 89, 85, 82 }
                });
            /*When using LINQ to query non-generic IEnumerable collections 
             * such as ArrayList, you must explicitly declare the type 
             * of the range variable to reflect the specific type of the 
             * objects in the collection. */
            var query = from Student student in arrList
                        where student.Scores[0] > 95
                        select student;

            foreach (Student s in query)
                Console.WriteLine(s.LastName + ": " + s.Scores[0]);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
