using Microsoft.EntityFrameworkCore;
using WebApiForAngular.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using WebApiForAngular.Entity.Concrete;

namespace WebApiForAngular.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class WebApiForAngularContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-IRRMMDJ; database = WebApiForAngular; integrated security = true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new DepartmentMap());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
