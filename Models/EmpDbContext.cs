using Microsoft.EntityFrameworkCore;

namespace EmployeeWebSite.Models
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions options) : base(options)
        {
        }
       public DbSet<Employee> Employees { get; set;}
    }
}
