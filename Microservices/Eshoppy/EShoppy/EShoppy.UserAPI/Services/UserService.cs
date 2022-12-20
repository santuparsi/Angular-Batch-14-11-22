using EShoppy.UserAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.UserAPI.Repositories;
namespace EShoppy.UserAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public Item GetItem(string itemName)
        {
            try
            {
                return repository.GetItem(itemName);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Purchase(Payment payment)
        {
            try
            {
                repository.PurchaseItem(payment);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
