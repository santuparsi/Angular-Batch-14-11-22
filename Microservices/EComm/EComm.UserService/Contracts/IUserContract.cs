using EComm.UserService.Entities;
using EComm.UserService.Models;

namespace EComm.UserService.Contracts
{
    public interface IUserContract
    {
        void Register(User user);
        User Validate(Login login);
    }
}
