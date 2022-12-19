using Microsoft.EntityFrameworkCore;
namespace EComm.ProductService.Entities
{
    public class ProductDB1219Context:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductDB1219Context(DbContextOptions<ProductDB1219Context> options) : base(options)
        {

        }
    }
}
