using Microsoft.AspNetCore.Mvc;
using HandsOnEFCodeFirst_Demo1.Entities;
namespace HandsOnEFCodeFirst_Demo1.Controllers
{
    public class UserController : Controller
    {
        private MVCDB1128Context mVCDB1128;
        public UserController()
        {
            mVCDB1128 = new MVCDB1128Context();
        }
        [Route("GetAllUsers")]
        public IActionResult Index()
        {
            List<User> users = mVCDB1128.Users.ToList(); //retrun all users from the user table
            return View(users);
        }
        [Route("AddUser")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost,Route("AddUser")]
        public IActionResult Create(User user)
        {
            try
            {
                mVCDB1128.Users.Add(user);
                mVCDB1128.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
        [HttpGet,Route("GetUserById/{id}")]
        public IActionResult Details(int id)
        {
            try
            {
                User user = mVCDB1128.Users.Find(id);
                return View(user);
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
        public IActionResult Delete(int id)
        {
            try
            {
                User user = mVCDB1128.Users.Find(id);
                mVCDB1128.Users.Remove(user);
                mVCDB1128.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
    }
}
