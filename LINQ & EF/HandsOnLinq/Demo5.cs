using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinq
{
    class Demo5
    {
        static void Main()
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };
            //create a query that obtain only +ve numbers
            var posnums = from n in nums where n > 0 select n;
            foreach (int i in posnums)
            {
                Console.Write(i + " ");
            }
            nums[1] = 12;
            Console.WriteLine();
            foreach (int i in posnums)
            {
                Console.Write(i + " ");
            }


            Console.Read();
        }
    }
}
