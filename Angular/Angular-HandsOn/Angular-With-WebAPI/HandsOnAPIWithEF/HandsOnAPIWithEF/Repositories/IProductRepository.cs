using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithEF.Models;
namespace HandsOnAPIWithEF.Repositories
{
   public interface IProductRepository
    {
        public List<Products> GetAll();
        public Products Get(int pid);
        public void Add(Products item);
        public void Delete(int pid);
        public void Update(Products item);
    }
}
