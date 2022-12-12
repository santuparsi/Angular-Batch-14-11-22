using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDbFirst_Demo.Entities
{
    public partial class Project
    {
        public Project()
        {
            Employees = new HashSet<Employee>();
        }

        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TeamSize { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
