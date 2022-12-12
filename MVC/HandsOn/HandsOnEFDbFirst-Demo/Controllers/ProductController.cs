using Microsoft.AspNetCore.Mvc;
using HandsOnEFDbFirst_Demo.Repisitory;
using HandsOnEFDbFirst_Demo.Entities;
namespace HandsOnEFDbFirst_Demo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository productRepository;
        public ProductController(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [Route("GetProducts")]
        public IActionResult Index() //Get All Proudcts
        {
            return View(productRepository.GetProducts());
        }
        [Route("GetById/{id}")]
        public IActionResult Details(int id)
        {
            try
            {
                return View(productRepository.GetProduct(id));
            }
            catch (System.Exception ex)
            {

                return View("Error");
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            try
            {
                productRepository.AddProduct(product);
                return RedirectToAction("Index");
            }
            catch (System.Exception ex)
            {

                return View("Error");
            }
        }
             
    }
}
