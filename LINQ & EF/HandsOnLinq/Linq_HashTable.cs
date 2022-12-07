using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HandsOnLinqtoObjects
{
    class Linq_HashTable
    {
        static void Main()
        {
            Hashtable students = new Hashtable();
            students.Add(1, "Manoj");
            students.Add(2, "Vijay");
            students.Add(3, "Mohan");
            students.Add(4, "Lawrence");
            students.Add(5, "Rajesh");
            //get keys
           var result = from int s in students.Keys select s;
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (int k in result)
            {
                Console.WriteLine("{0} {1}", k, students[k]);
            }
            //get values
            var result1 = from int s1 in students.Keys  select students[s1];
            foreach (string s2 in result1)
            {
                Console.WriteLine(s2);
            }
            Console.Read();

        }
      
    }
}
