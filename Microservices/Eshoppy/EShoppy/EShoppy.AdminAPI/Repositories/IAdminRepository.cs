using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.AdminAPI.Entities;
namespace EShoppy.AdminAPI.Repositories
{
    public interface IAdminRepository
    {
        void AddItem(Item item);
        List<Item> GetItems();
        Item GetItem(string itemId);
        void UpdateItem(Item item);
        void DeleteItem(string itemId);
    }
}
