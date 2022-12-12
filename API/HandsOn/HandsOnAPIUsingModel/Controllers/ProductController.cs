using HandsOnAPIUsingModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public List<Product> products = new List<Product>()
        {
            new Product(){ProductId=34203,ProductName="Bottle",Price=40,Stock=100},
             new Product(){ProductId=45353,ProductName="Choclate",Price=50,Stock=100},
        };
        //EndPoints(Action Methods)
        [HttpGet]
        public List<Product> GetProducts()
        {
            return products;
        }
        [HttpGet,Route("GetProduct/{id}")]
        public Product? GetProduct(int id)
        {
            return products.SingleOrDefault(p => p.ProductId == id);
        }
    }
}
