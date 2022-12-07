using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOnLinqtoObjects
{
    class Demo4
    {
        static void Main()
        {
            int[] arr = { 20, -12, 97, 86, -12, 77, 12, 0, 17, -87, 78 }; 
            //filter +ve values from the array and return to IEnumerable type.
           IEnumerable<int> FilteredValues = from val in arr
                                              where val > 0
                                              select val;
           foreach (int i in FilteredValues)
           {
               Console.Write(i + "\t");
           }
           Console.Read();
        }
    }
}
