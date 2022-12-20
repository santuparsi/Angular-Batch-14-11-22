using EShoppy.AdminAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.AdminAPI.Repositories;
namespace EShoppy.AdminAPI.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository repository;

        public AdminService(IAdminRepository repository)
        {
            this.repository = repository;
        }

        public void AddItem(Item item)
        {
            try
            {
                repository.AddItem(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteItem(string itemId)
        {
            try
            {
                repository.DeleteItem(itemId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Item GetItem(string itemId)
        {
            try
            {
                return repository.GetItem(itemId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Item> GetItems()
        {
            try
            {
                return repository.GetItems();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateItem(Item item)
        {
            try
            {
                repository.UpdateItem(item);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
