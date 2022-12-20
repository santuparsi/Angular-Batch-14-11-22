using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.UserAPI.Services;
using EShoppy.UserAPI.Entities;
using Microsoft.AspNetCore.Authorization;

namespace EShoppy.UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="User")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        [Route("GetItem/{itemName}")]
       [Authorize(Roles ="Admin")]
        public IActionResult GetItem(string itemName)
        {
            try
            {
                Item item = userService.GetItem(itemName);
                return Ok(item);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);

            }
        }
        [HttpPost]
        [Route("Purchase")]
        public IActionResult Purchase(Payment payment)
        {
            try
            {
                userService.Purchase(payment);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
                
            }
        }
    }
}
