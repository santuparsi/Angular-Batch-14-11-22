using System;
using System.Linq;
using System.Collections.Generic;
namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] no = { 12, 23, 34, 45, 56, 67, 78, 89 };
            //fetch even values
            //IEnumerable<int> result = from i in no
            //                          where i % 2 == 0
            //                          select i;
            var result = from i in no
                         where i % 2 == 0
                         select i;
            //no[1] = 24;
            Console.WriteLine(result);
            //foreach (int k in result)
            //{
            //    Console.WriteLine(k);
            //}
            ////fetch values > 30
            result = from i in no where i > 30 select i;
            //Console.WriteLine(result);
            ////sorting array elements
            result = from i in no
                     where i % 2 != 0
                     orderby i ascending
                     select i;
            //no[0] = 13;
            ////deffered execuation
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            result = from i in no where i > 40 && i%2!=0 select i;

            var result_sorting = from i in no where i > 30 orderby i select i;

            foreach (var item in result_sorting)
                Console.WriteLine(item);


        }
    }
}
