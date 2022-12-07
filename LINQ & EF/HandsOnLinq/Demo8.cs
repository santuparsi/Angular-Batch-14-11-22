using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinq
{
    class Demo8
    {
        static void Main()
        {
            int[] nums = { 10,-19,4,7,2,-5,0 };
            //create a query with obtains array values in sorted order
            var assenvalues = from n in nums
                              orderby n
                              select n;
            Console.WriteLine("Values in assending order: ");
            foreach (int i in assenvalues)
            {
                Console.Write(i + " ");
            }
            //create a query with obtains array values in desending oders
            var posnums = from n in nums
                          orderby n descending
                          select n;
            Console.WriteLine();
            Console.WriteLine("Values in desending order: ");
            foreach (int k in posnums)
            {
                Console.Write(k + " ");
            }
            Console.Read();
        }
    }
}
