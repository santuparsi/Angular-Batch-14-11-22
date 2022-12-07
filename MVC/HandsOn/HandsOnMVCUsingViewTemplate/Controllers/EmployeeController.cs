using HandsOnMVCUsingViewTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingViewTemplate.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create() //standard helpers
        {
            return View();
        }
        public IActionResult Create1() //strongly typed helpers
        {
            return View();
        }
        public IActionResult Create2() //tag helpers
        {
            return View();
        }
        public IActionResult Create3() //use scaffolding
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            //Adding employee details to the db
            return Json(employee);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Validate(string uname,string pwd)
        {
            return Json(new {Username=uname,Password=pwd });
        }
    }
}
