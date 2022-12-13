using HandsOnAPIWithEF.Contracts;
using HandsOnAPIWithEF.Entities;

namespace HandsOnAPIWithEF.Services
{
    public class ProductRepository : IProductContract
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                Product product = _context.Products.Find(id);
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditProduct(Product product)
        {
            try
            {
              
                _context.Products.Update(product);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product GetProduct(int id)
        {
            try
            {
                Product product = _context.Products.Find(id);
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetProducts()
        {
            try
            {

                return _context.Products.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
