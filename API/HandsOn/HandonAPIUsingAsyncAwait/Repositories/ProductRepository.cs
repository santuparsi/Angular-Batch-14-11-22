using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandonAPIUsingAsyncAwait.Models;
namespace HandonAPIUsingAsyncAwait.Repositories
{
    public class ProductRepository: IProductRepository
    {
        public List<Product> products = new List<Product>()
        {
            new Product(){ProductId=1,ProductName="Mouse",Price=500,Stock=10},
            new Product(){ProductId=2,ProductName="Bottle",Price=500,Stock=10},
            new Product(){ProductId=3,ProductName="Keypad",Price=500,Stock=10},
            new Product(){ProductId=4,ProductName="Keyboard",Price=500,Stock=10},
            new Product(){ProductId=5,ProductName="Pendrive",Price=500,Stock=10},
            new Product(){ProductId=6,ProductName="Keychain",Price=500,Stock=10},
        };

        public async Task<List<Product>> GetProducts()
        {
             return await Task.Run(() =>
            {
                 return products.ToList();
            });
        }

        public async Task<Product> GetProduct(int id)
        {
            return await Task.Run(() =>
            {
                return products.SingleOrDefault(p => p.ProductId == id);
            });
        }

      
    }
}
