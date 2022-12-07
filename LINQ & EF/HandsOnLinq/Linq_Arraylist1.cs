using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HandsOnLinqtoObjects
{
    class Linq_Arraylist1
    {
        static void Main()
        {
            ArrayList ar = new ArrayList() { 1, 2, 4, 8, 23 };
            var v = from  int a in ar orderby a select a;
            foreach (int i in v)
            {
                Console.Write(i+"\t");
            }
            Console.Read();
        }
    }
}
