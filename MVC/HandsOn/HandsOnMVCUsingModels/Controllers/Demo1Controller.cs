using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingModels.Models;
using HandsOnMVCUsingModels.ViewModel;
using System.Collections.Generic;
namespace HandsOnMVCUsingModels.Controllers
{
    public class Demo1Controller : Controller
    {
        public IActionResult Index() //bind 2 entity details in the view
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmployeeId=1,Name="Rajan",Salary=34000,JoinDate=DateTime.Now},
                 new Employee(){EmployeeId=2,Name="Karan",Salary=34000,JoinDate=DateTime.Parse("12.2.2020")},
            };
            List<Project> projects = new List<Project>()
            {
                new Project(){ProjectCode="P0001",ProjectName="HealthCare",TeamSize=10,StartDate=DateTime.Parse("12.2.2022")},
                 new Project(){ProjectCode="P0002",ProjectName="BCInsurence",TeamSize=12,StartDate=DateTime.Parse("12.2.2021")}
            };
            ViewModel1 viewModel1 = new ViewModel1()
            {
                Employees = employees,
                Projects = projects
            };
            return View(viewModel1);
        }
        public IActionResult GetAll()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmployeeId=1,Name="Rajan",Salary=34000,JoinDate=DateTime.Now,ProjectCode="P0001"},
                 new Employee(){EmployeeId=2,Name="Karan",Salary=34000,JoinDate=DateTime.Parse("12.2.2020"),ProjectCode="P0002"},
            };
            List<Project> projects = new List<Project>()
            {
                new Project(){ProjectCode="P0001",ProjectName="HealthCare",TeamSize=10,StartDate=DateTime.Parse("12.2.2022")},
                 new Project(){ProjectCode="P0002",ProjectName="BCInsurence",TeamSize=12,StartDate=DateTime.Parse("12.2.2021")}
            };
            List<ViewModel2> viewModel2 = new List<ViewModel2>();
            //for(int i=1;i<2;i++)
            //{
            //    viewModel2.Add(new ViewModel2()
            //    {
            //        EmployeeId = employees[i].EmployeeId,
            //        Name= employees[i].Name,
            //        ProjectCode = projects[i].ProjectCode,
            //        ProjectName = projects[i].ProjectName
            //    });

            //}
            //writing join using linq
            viewModel2 = (from l1 in employees
                          join l2 in projects
                          on l1.ProjectCode equals l2.ProjectCode
                          select new ViewModel2()
                          {
                              EmployeeId = l1.EmployeeId,
                              Name = l1.Name,
                              ProjectCode = l2.ProjectCode,
                              ProjectName = l2.ProjectName
                          }).ToList();


            return View(viewModel2);
        }
    }
}
