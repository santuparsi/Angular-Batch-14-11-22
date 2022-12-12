using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDbFirst_Demo.Entities
{
    public partial class EmployeeProject
    {
        public int EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
    }
}
