using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.AdminAPI.Entities;
using EShoppy.AdminAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace EShoppy.AdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService adminService;

        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }
        [HttpGet]
        [Route("GetItems")]
        public IActionResult GetItems()
        {
            try
            {
                List<Item> items=adminService.GetItems();
                return Ok(items);

            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetItem/{itemId}")]
        public IActionResult GetItem(string itemId)
        {
            try
            {
                Item item = adminService.GetItem(itemId);
                return Ok(item);

            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddItem(Item item)
        {
            try
            {
                adminService.AddItem(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("EditItem")]
        public IActionResult EditItem(Item item)
        {
            try
            {
                adminService.UpdateItem(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteItem/{id}")]
        public IActionResult DeleteItem(string itemId)
        {
            try
            {
                adminService.DeleteItem(itemId);
                return Ok();
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
    }
}
