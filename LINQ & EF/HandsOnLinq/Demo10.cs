using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinq
{
    internal class Demo10
    {
        static void Main()
        {
            string[] flowers = { "dahlia", "rose", "lotus", "lily", "hibiscus", "daffodil" };
            var f1 = from flower in flowers
                     where flower.StartsWith("d")
                     select flower;
            //IEnumerable<string> f = flowers.Where(flower => flower.StartsWith("d"));
            var f = flowers.Where(flower => flower.StartsWith("d"));
            foreach (string g in f)
            {
                Console.WriteLine(g);

            }
        }
    }
}