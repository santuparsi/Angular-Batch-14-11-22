using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingControllersAndViews.Controllers
{
    public class DemoController : Controller
    {
       //action methods 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Greet()
        {
            return View();
        }
    }
}
