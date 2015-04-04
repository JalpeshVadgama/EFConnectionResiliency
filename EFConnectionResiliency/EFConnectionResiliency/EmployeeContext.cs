using System.Data.Entity;

namespace EFConnectionResiliency
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(): base("DefaultConnectionString")
        {
            // public constructor to use connection string
        }
        public DbSet<Employee> Employees { get; set; } 
    }
}