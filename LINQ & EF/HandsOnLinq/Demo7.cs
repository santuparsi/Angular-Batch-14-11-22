using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinq
{
    class Demo7
    {
        static void Main()
        {
            string []str={"Google.com",".net","Myhcl.com","hcl.net","test"
                             ,".network","hsnmaeC.net","hsnameD.com"};
            //create a query that obtains internet address that end with .com
            var netAddrs = from addr in str
                           where addr.EndsWith(".com")
                           select addr;
            foreach (var s in netAddrs)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
