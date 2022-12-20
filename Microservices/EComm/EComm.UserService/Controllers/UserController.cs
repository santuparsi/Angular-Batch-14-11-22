using EComm.UserService.Contracts;
using EComm.UserService.Entities;
using EComm.UserService.Models;
using EComm.UserService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserContract userRepository;

        public UserController(IUserContract userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpPost, Route("AddUser")]
        public IActionResult Register(User user)
        {
            try
            {
                userRepository.Register(user);
                return StatusCode(200, user);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost, Route("Validate")]
        public IActionResult Login(Login login)
        {
            try
            {
                User user = userRepository.Validate(login);
              
                return StatusCode(200, user);
            }

            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

       
    }
}
