using Microsoft.EntityFrameworkCore;
namespace HandsOnMVCUsingEFCodeFirst_Demo2.Entties
{
    public class MVCDB1128Context:DbContext
    {
        //Entity sets
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configute sqlserver connection
            optionsBuilder.UseSqlServer("Data Source=SANTU\\MSSQLSERVER2019;Initial Catalog=MVCDB1128;Integrated Security=True");
        }
    }
}
