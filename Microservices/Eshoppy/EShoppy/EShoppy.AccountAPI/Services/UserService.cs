using EShoppy.AccountAPI.Entities;
using EShoppy.AccountAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.AccountAPI.Repositories;
namespace EShoppy.AccountAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public User Login(Login login)
        {
            try
            {
                return repository.Login(login);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Register(User user)
        {
            try
            {
                 repository.Register(user);
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
