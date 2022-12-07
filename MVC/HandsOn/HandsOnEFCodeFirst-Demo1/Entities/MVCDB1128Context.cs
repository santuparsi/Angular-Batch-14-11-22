using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirst_Demo1.Entities
{
    public class MVCDB1128Context:DbContext
    {
        //Entity sets
        public DbSet<User> Users { get; set; }
        //Configure the ConnectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //write connectionstring to sqlserver
            optionsBuilder.UseSqlServer("Data Source=SANTU\\MSSQLSERVER2019;Initial Catalog=MVCDB1128;Integrated Security=True");
        }
    }
}
