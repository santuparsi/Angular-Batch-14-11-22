using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double Salary { get; set; }
    }

    class Demo13
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>() //List of Employees
            {
                new Employee(){Eid=1,Ename="Rohan",Salary=12000},
                new Employee(){Eid=2,Ename="Karan",Salary=12000},
                new Employee(){Eid=3,Ename="Jeson",Salary=18000},
                new Employee(){Eid=4,Ename="Suman",Salary=16000},
                new Employee(){Eid=5,Ename="Raman",Salary=16000},
                new Employee(){Eid=6,Ename="Charan",Salary=18000},
            };
            Employee e1 = employees.First();
            e1 = employees[0];
            e1 = employees.Where(i => i.Ename.StartsWith("R")).First();
            e1 = employees.Where(i => i.Ename.StartsWith("R")).Last();
            //FirstOrDefault() return null when there is no items in sequence
            e1 = employees.Where(i => i.Ename.StartsWith("T")).FirstOrDefault();
            if(e1!=null)
            Console.WriteLine("{0} {1}", e1.Eid, e1.Ename);
            //LastOrDefault() return null when there is no items in sequence
            e1 = employees.Where(i => i.Ename.StartsWith("T")).LastOrDefault();
            if (e1 != null)
                Console.WriteLine("{0} {1}", e1.Eid, e1.Ename);
            e1 = employees.Where(i => i.Eid == 1).Single();//when sequence contains only one element
          // e1 = employees.Single(i => i.Eid>10); //throws exception when sequence return multile elemens or no elementes
            e1 = employees.SingleOrDefault(i => i.Eid == 1); //return null value when there is no objects in the sequence
            if (e1 != null)
                Console.WriteLine("{0} {1}", e1.Eid, e1.Ename);
            else
                Console.WriteLine("Invalid Id");
            //ToList() used when sequence contain more than one element.
            List<Employee> employees1 = employees.Where(i => i.Ename.StartsWith("R")).ToList(); //convert result set into list type
            e1 = employees.Where(i => i.Eid > 3).ElementAt(1); //returns element at 2nd index
            e1 = employees.Where(i => i.Eid > 3).ElementAtOrDefault(10);
            if(e1!=null)
            {
                Console.WriteLine("{0} {1}", e1.Eid, e1.Ename);
            }
            //Group by
            var result2 = (from i in employees group i by i.Salary);
            //result2 = employees.GroupBy(i => i.Salary);
            foreach(var item in result2)
            {
                Console.WriteLine("Employee havding salary of {0} ", item.Key);
                foreach(var i in item)
                {
                    Console.WriteLine("Name:{0}", i.Ename);
                }
            }
        }
    }
}
