using CRUDAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
