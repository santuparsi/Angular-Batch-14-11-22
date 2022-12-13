using HandsOnAPIUsingModel.Models;

namespace HandsOnAPIUsingModel.Repositories
{
    public class ProductRepository
    {
        public List<Product> products = new List<Product>()
        {
            new Product(){ProductId=34203,ProductName="Bottle",Price=40,Stock=100},
             new Product(){ProductId=45353,ProductName="Choclate",Price=50,Stock=100},
        };
        public List<Product> GetProducts()
        {
            return products;
        }
        public Product? GetProduct(int id)
        {
            return products.SingleOrDefault(p => p.ProductId == id);
        }
        public void AddProduct(Product item)
        {
            products.Add(item);
        }
    }
}
