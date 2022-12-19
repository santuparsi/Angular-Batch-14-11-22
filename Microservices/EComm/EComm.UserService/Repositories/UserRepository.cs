using EComm.UserService.Contracts;
using EComm.UserService.Entities;
using EComm.UserService.Models;

namespace EComm.UserService.Repositories
{
    public class UserRepository : IUserContract
    {
        private readonly UserDB1219Context userDB1219Context;

        public UserRepository(UserDB1219Context userDB1219Context)
        {
            this.userDB1219Context = userDB1219Context;
        }

        public void Register(User user)
        {
            try
            {
                userDB1219Context.Users.Add(user);
                userDB1219Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Validate(Login login)
        {
            try
            {
                User user=userDB1219Context.Users.SingleOrDefault(u => u.Email == login.Email && u.Password == login.Password);
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
