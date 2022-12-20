using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.UserAPI.Entities;
namespace EShoppy.UserAPI.Repositories
{
    public interface IUserRepository
    {
        Item GetItem(string itemName);
        void PurchaseItem(Payment payment);
    }
}
