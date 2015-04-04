using System;

namespace EFConnectionResiliency
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FirstName = "Jalpesh",
                LastName = "Vadgama",
                Designation = "Project Manager"
            };

            using (EmployeeContext employeeContext = new EmployeeContext())
            {
                employeeContext.Employees.Add(employee);
                employeeContext.SaveChanges();
            }
            Console.WriteLine("Employee Created");
        }
    }
}
