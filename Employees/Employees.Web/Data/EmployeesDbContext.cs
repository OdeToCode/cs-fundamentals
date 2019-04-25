using Employees.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employees.Web.Data
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                        .HasIndex(e => new { e.FirstName, e.LastName });
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
