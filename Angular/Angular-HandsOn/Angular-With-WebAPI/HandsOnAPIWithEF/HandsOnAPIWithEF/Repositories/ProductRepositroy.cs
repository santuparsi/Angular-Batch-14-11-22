using HandsOnAPIWithEF.Models;
using Microsoft.AspNetCore.Authorization.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HandsOnAPIWithEF.Repositories
{
    public class ProductRepositroy : IProductRepository
    {
        private ProductDBContext db;
        public ProductRepositroy()
        {
            db = new ProductDBContext();
        }
        public void Add(Products item)
        {
            db.Products.Add(item);
            db.SaveChanges();
        }

        public void Delete(int pid)
        {
            Products p = db.Products.Find(pid);
            db.Products.Remove(p);
            db.SaveChanges();
        }

        public Products Get(int pid)
        {
            return db.Products.SingleOrDefault(p => p.Pid == pid);
        }

        public List<Products> GetAll()
        {
            return db.Products.ToList();
        }

        public void Update(Products item)
        {

           // update few fields
            //Products p = db.Products.Find(item.Pid);
            //p.Price = item.Price;
            //db.Products.Update(p);
            db.Products.Update(item);
            db.SaveChanges();
        }
    }
}
