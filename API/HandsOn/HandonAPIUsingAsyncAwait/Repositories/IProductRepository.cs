using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandonAPIUsingAsyncAwait.Models;
namespace HandonAPIUsingAsyncAwait.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
    }
}
