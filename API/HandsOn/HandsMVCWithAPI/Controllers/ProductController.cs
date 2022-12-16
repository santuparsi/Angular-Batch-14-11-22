using HandsMVCWithAPI.Contracts;
using HandsMVCWithAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HandsMVCWithAPI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductContract productContract;

        public ProductController(IProductContract productContract)
        {
            this.productContract = productContract;
        }

        [Route("GetAll")]
        public IActionResult Index() //Get All Products
        {
            List<Product> products = productContract.GetProducts();
            return View(products);
        }
        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            try
            {
                Product product = productContract.GetProduct(id);
                return View(product);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productContract.AddProduct(product);
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        public IActionResult Delete(int id)
        {
            productContract.DeleteProduct(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Product product = productContract.GetProduct(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                productContract.EditProduct(product);
                return RedirectToAction("Index");
            }
            else
                return View();
        }
    }
}
