using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinq
{
    class Demo6
    {
        static void Main()
        {
            //filter values with where
            int[] nums = { 1, -2, 3, -3, 0, -8, 12, 19, 6, 9, 10 };
            //create a query that obtains +ve values less than 10 using multiple where conditions
            //var posnum = from int n in nums 
            //             where n > 0 
            //             where n < 10 
            //             select n;
            //create a query that obtains +ve values less than 10 using single where condition.
            var posnum = from n in nums
                         where n > 0 && n < 10
                         select n;
            foreach (int i in posnum)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
