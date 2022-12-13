using HandsOnAPIUsingModel.Models;
using HandsOnAPIUsingModel.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository productRepository;

        public ProductController(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        //EndPoints(Action Methods)
        [HttpGet,Route("GetAllProducts")]
        public List<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }
        [HttpGet,Route("GetProduct/{id}")]
        public Product? GetProduct(int id)
        {
            return productRepository.GetProduct(id);
        }
        [HttpPost,Route("AddProduct")]
        public string Add(Product item)
        {
          productRepository.AddProduct(item);
            return "Product Added"; //message is sent as json
        }
    }
}
