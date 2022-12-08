using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingEFCodeFirst_Demo2.Services;
using HandsOnMVCUsingEFCodeFirst_Demo2.Entties;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnMVCUsingEFCodeFirst_Demo2.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeService employeeService;
        private ProjectService projectService;
        public EmployeeController()
        {
            employeeService = new EmployeeService();
            projectService = new ProjectService();

        }
        [Route("GetEmployees")]
        public IActionResult Index()
        {
            try
            {
                List<Employee> employees = employeeService.GetEmployees();
                return View(employees);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Details")]
        public IActionResult Details(int id)
        {
            try
            {
                Employee employee = employeeService.GetEmployee(id);
                return View(employee);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                employeeService.DeleteEmployee(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<string> list= projectService.GetProjectCodes();
            List<SelectListItem> selectLists = new List<SelectListItem>();
            foreach(var item in list)
            {
                selectLists.Add(new SelectListItem() { Text = item });
            }
            ViewBag.ProjectCode = selectLists;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            try
            {
                ViewBag.ProjectCode = projectService.GetProjectCodes();
                employeeService.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<string> list = projectService.GetProjectCodes();
            List<SelectListItem> selectLists = new List<SelectListItem>();
            foreach (var item in list)
            {
                selectLists.Add(new SelectListItem() { Text = item });
            }
            ViewBag.ProjectCode = selectLists;
            Employee employee = employeeService.GetEmployee(id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            try
            {
                employeeService.EditEmployee(employee);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
        [Route("GetEmployeeProjects")]
        public IActionResult GetAll()
        {
            return View(employeeService.GetEmployeeProjects());
        }

    }
}
