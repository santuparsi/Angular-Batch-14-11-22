using System;
using System.Collections.Generic;

namespace HandsOnAPIWithEF.Models
{
    public partial class Products
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
    }
}
