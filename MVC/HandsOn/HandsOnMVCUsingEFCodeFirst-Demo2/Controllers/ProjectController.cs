using HandsOnMVCUsingEFCodeFirst_Demo2.Services;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingEFCodeFirst_Demo2.Entties;
namespace HandsOnMVCUsingEFCodeFirst_Demo2.Controllers
{
    public class ProjectController : Controller
    {
        public ProjectService projectService;
        public ProjectController()
        {
            projectService = new ProjectService();
        }
        [HttpGet]
        public IActionResult Create()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult Create(Project project)
        {
            try
            {
                
                projectService.AddProject(project);
                return View();
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
    }
}
