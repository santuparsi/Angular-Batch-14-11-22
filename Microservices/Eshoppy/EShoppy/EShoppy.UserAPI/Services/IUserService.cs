using EShoppy.UserAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppy.UserAPI.Services
{
    public interface IUserService
    {
        Item GetItem(string itemName);
        void Purchase(Payment payment);
    }
}
