using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingModelValidations.Models;
using NuGet.Protocol.Plugins;

namespace HandsOnMVCUsingModelValidations.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                
                 //Add model details to db table
                return Json(user);

            }
            else
                return View();
        }
        [HttpGet]
        public IActionResult Validate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Validate(Login login)
        {
            if (ModelState.IsValid)
            {
                if (login.Email == "Admin@gmail.com" && login.Password == "12345")
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.ErrorMsg = "Invalid Credentials";
                    return View();
                }
            }
            else
                return View();
        }
    }
}
