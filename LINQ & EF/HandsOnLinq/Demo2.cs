using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo2
    {
        static void Main()
        {
           
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9, 6 };
            var result = from i in numbers where i % 2 == 0 select i * i;
            //return square array no's >50
            result = from i in numbers where i * i > 50 select i * i;
            result = from i in numbers let k = i * i where k > 50 select k;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
