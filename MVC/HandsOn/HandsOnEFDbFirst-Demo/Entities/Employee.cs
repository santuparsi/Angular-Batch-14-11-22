using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDbFirst_Demo.Entities
{
    public partial class Employee
    {
        public int EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Designation { get; set; }
        public decimal? Salary { get; set; }
        public string ProjectCode { get; set; }

        public virtual Project ProjectCodeNavigation { get; set; }
    }
}
