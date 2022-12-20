using EComm.ProductService.Contracts;
using EComm.ProductService.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm.ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductContract productContract;

        public ProductController(IProductContract productContract)
        {
            this.productContract = productContract;
        }
        [HttpPost,Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                productContract.AddProduct(product);
                return StatusCode(200, product);
            }
            catch (Exception ex)
            {

                return StatusCode(200, ex.Message);
            }
        }
        [HttpGet,Route("Search/{pname}")]
        public IActionResult Get(string pname)
        {
            try
            {
                Product product = productContract.SearchProduct(pname);
                return StatusCode(200, product);
            }
            catch (Exception ex)
            {

                return StatusCode(200, ex.Message);
            }
        }
    }
}
