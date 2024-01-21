using EmployeeDepartment.Models;
using System.Data.Entity;

namespace EmployeeDepartment.EF
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext():base("EmployeeConnSt")
        {
                
        }

        public DbSet<Department>Departments { get; set; }

        public DbSet<Employee>Employees { get; set; }
    }
}