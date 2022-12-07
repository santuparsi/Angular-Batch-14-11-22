using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo1
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7,7, 8, 9,6 };
           
            //return uniq values
            var query1=(from i in numbers where i>5 select i).Distinct(); //return uniq values from the result set
            //var query2 = numbers.Distinct();
            foreach (var i in query1)
                Console.WriteLine(i);
        }
    }
}
