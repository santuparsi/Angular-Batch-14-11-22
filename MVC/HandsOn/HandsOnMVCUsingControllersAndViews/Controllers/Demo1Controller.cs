using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingControllersAndViews.Controllers
{
    public class Demo1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            string name = "Abhishek";
            //set value in ViewData
            ViewData["un"] = name;
            return View();
        }
        public IActionResult Greet(string name)
        {
            ViewData["n"] = name;
            return View();
        }
        public IActionResult GetFlowers()
        {
            ViewData["flower"] = new string[] { "Rose", "Lilly", "Jasmine", "Tulips" };
            return View();
        }
        public IActionResult GetCities()
        {
            List<string>?cities= new List<string>() { "Chennai", "Bangalore", "Hyderabad", "Puen", "Delhi" };
            ViewBag.Cities = cities;
            return View();
        }
    }
}
