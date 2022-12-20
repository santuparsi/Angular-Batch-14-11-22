using EShoppy.AdminAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.AdminAPI.DBContext;
namespace EShoppy.AdminAPI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly EShoppyDBContext context;

        public AdminRepository(EShoppyDBContext context)
        {
            this.context = context;
        }

        public void AddItem(Item item)
        {
            try
            {
                context.Items.Add(item);
                context.SaveChanges();
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
                Item item = context.Items.SingleOrDefault(i => i.ItemId == itemId);
                context.Items.Remove(item);
                context.SaveChanges();
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
                return context.Items.SingleOrDefault(i => i.ItemId == itemId);
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
                return context.Items.ToList();
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
                context.Items.Update(item);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
