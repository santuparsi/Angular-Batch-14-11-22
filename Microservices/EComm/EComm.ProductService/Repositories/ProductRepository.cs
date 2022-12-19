using EComm.ProductService.Contracts;
using EComm.ProductService.Entities;

namespace EComm.ProductService.Repositories
{
    public class ProductRepository : IProductContract
    {
        private readonly ProductDB1219Context productDB1219Context;

        public ProductRepository(ProductDB1219Context productDB1219Context)
        {
            this.productDB1219Context = productDB1219Context;
        }

        public void AddProduct(Product product)
        {
            try
            {
                productDB1219Context.Products.Add(product);
                productDB1219Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
