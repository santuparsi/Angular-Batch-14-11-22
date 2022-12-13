using HandsOnAPIWithEF.Contracts;
using HandsOnAPIWithEF.Entities;
using HandsOnAPIWithEF.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIWithEF.Controllers
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
        [HttpGet,Route("GetAllProducts")]
        public IActionResult GetAll()
        {
            try
            {
                List<Product> products = productContract.GetProducts();
                return StatusCode(200, products);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetProduct/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Product product = productContract.GetProduct(id);
                if (product != null)
                    return StatusCode(200, product);
                else
                    return StatusCode(404, "Invalid Product Id");
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost,Route("AddProduct")]
        public IActionResult Add(Product product)
        {
            try
            {
                productContract.AddProduct(product);
               
                return StatusCode(200, product);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut, Route("EditProduct")]
        public IActionResult Update(Product product)
        {
            try
            {
                productContract.EditProduct(product);

                return StatusCode(200, product);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete, Route("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                productContract.DeleteProduct(id);  
                    return StatusCode(200, "Product Deleted");
              
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        //[HttpGet,Route("TestMethod/{name}/{age}")]
        //public IActionResult Test(string name,int age)
        //{
        //    return Ok("Person Details");
        //}
    }
}
