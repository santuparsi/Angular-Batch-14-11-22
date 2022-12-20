using EShoppy.AccountAPI.Entities;
using EShoppy.AccountAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.AccountAPI.DBContext;
namespace EShoppy.AccountAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EShoppyDBContext context;

        public UserRepository(EShoppyDBContext context)
        {
            this.context = context;
        }

        public User Login(Login login)
        {
            try
            {
                return context.Users.SingleOrDefault(u => u.Email == login.Email && u.Password == login.Password);
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
                context.Users.Add(user);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
