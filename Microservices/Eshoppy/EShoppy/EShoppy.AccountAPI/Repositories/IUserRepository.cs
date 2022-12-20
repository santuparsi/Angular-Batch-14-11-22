using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.AccountAPI.Entities;
using EShoppy.AccountAPI.Model;
namespace EShoppy.AccountAPI.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User Login(Login login);
    }
}
