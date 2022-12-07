using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace HandsOnLinq
{
    class OfTypeDemo
    {
        static void Main()
        {
            /*The OfType operator filters the collection based on the ability to cast an 
            element in a collection to a specified type.*/
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            var intResult = from s in mixedList.OfType<int>()
                            select s;
        }
    }
}
