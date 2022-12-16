using HandsMVCWithAPI.Models;

namespace HandsMVCWithAPI.Contracts
{
    public interface IProductContract
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void AddProduct(Product product);
        void EditProduct(Product product);
        void DeleteProduct(int id);
    }
}
