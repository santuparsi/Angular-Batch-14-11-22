using EShoppy.AccountAPI.Entities;
using EShoppy.AccountAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppy.AccountAPI.Services
{
    public interface IUserService
    {
        void Register(User user);
        User Login(Login login);
    }
}
