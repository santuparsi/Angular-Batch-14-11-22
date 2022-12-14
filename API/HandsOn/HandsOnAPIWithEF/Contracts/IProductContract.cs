using HandsOnAPIWithEF.Entities;

namespace HandsOnAPIWithEF.Contracts
{
    public interface IProductContract
    {
        Task<List<Product>> GetProducts();
        Product GetProduct(int id);
        void AddProduct(Product product);
        void EditProduct(Product product);
        void DeleteProduct(int id);
    }
}
