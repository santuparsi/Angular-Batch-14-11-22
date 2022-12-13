using Microsoft.EntityFrameworkCore;
namespace HandsOnAPIWithEF.Entities
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):base(options)
        {

        }
        //Entity set
        public DbSet<Product> Products { get; set; }
    }
}
