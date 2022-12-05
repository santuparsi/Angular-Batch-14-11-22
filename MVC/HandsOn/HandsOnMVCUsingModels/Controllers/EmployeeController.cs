using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingModels.Models;
namespace HandsOnMVCUsingModels.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee(){EmployeeId=1,Name="Rajan",JoinDate=new DateTime(2021,1,21),Salary=56000},
            new Employee(){EmployeeId=2,Name="Raman",JoinDate=new DateTime(2021,3,21),Salary=52000}
        };
        public IActionResult Index() //Get All Employees
        {
            return View(employees);
        }
        public IActionResult Details(int id)
        {
            //instantiate Employee Model
            //Employee employee = new Employee()
            //{
            //    EmployeeId = 1,
            //    Name = "Rajan",
            //    JoinDate = new DateTime(2021, 1, 21),
            //    Salary = 56000
            //};
            Employee employee = employees.SingleOrDefault(e => e.EmployeeId == id);
            return View(employee);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(Employee employee)
        {
            employees.Add(employee);
            return RedirectToAction("Index"); //redirects to Index action

        }
    }
}
