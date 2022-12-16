using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandonAPIUsingAsyncAwait.Models;
using HandonAPIUsingAsyncAwait.Repositories;
namespace HandonAPIUsingAsyncAwait.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository productRepository;
        public ProductController()
        {
            this.productRepository = new ProductRepository();
        }
        [HttpGet,Route("GetAllProducts")]
        public  async Task<IActionResult> GetAllProducts()
        {
            try
            {
                List<Product> products = await productRepository.GetProducts();
                return StatusCode(200, products);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet,Route("GetProduct")]
        public async Task<IActionResult> GetProduct(int id)
        {
            try
            {
                Product product = await productRepository.GetProduct(id);
                return StatusCode(200, product);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}
