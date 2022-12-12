using HandsOnEFDbFirst_Demo.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HandsOnEFDbFirst_Demo.Repisitory
{
    public class ProductRepository
    {
        private readonly PracticeDBContext practiceDBContext;
        public ProductRepository(PracticeDBContext practiceDBContext)
        {
            this.practiceDBContext = practiceDBContext;
        }
        public List<Product> GetProducts()
        {
            try
            {
                return practiceDBContext.Products.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public Product GetProduct(int productId)
        {
            try
            {
                return practiceDBContext.Products.Find(productId);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public void AddProduct(Product product)
        {
            try
            {
                practiceDBContext.Products.Add(product);
                practiceDBContext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
