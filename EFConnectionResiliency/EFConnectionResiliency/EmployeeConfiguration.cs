using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace EFConnectionResiliency
{
    public class EmployeeConfiguration : DbConfiguration
    {
        public EmployeeConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}