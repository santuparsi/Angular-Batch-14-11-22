using Microsoft.EntityFrameworkCore;
namespace EComm.UserService.Entities
{
    public class UserDB1219Context:DbContext
    {
        public UserDB1219Context(DbContextOptions<UserDB1219Context> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }

    }
}
