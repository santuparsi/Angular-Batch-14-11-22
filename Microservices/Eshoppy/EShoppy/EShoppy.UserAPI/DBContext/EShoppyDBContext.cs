using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EShoppy.UserAPI.Entities;
namespace EShoppy.UserAPI.DBContext
{
    public class EShoppyDBContext:DbContext
    {
        public EShoppyDBContext(DbContextOptions<EShoppyDBContext> options):base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
