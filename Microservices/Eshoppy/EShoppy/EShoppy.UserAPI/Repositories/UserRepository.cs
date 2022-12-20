using EShoppy.UserAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.UserAPI.Repositories;
using EShoppy.UserAPI.DBContext;
namespace EShoppy.UserAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EShoppyDBContext context;

        public UserRepository(EShoppyDBContext context)
        {
            this.context = context;
        }

        public Item GetItem(string itemName)
        {
            try
            {
                return context.Items.SingleOrDefault(i => i.ItemName == itemName);
            }
            catch (Exception)
            {

                throw;
            }
        }

      

        public void PurchaseItem(Payment payment)
        {
            try
            {
                payment.PaymentId = "P" + new Random().Next(1000, 9999);
                payment.PurchaseDate = DateTime.Now;
                context.Payments.Add(payment);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
