using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DependencyInjection;

public interface IEmployeeDAL
{
    List<Employee> SelectAllEmployees();
}

public class EmployeeDAL : IEmployeeDAL
{
    public List<Employee> SelectAllEmployees()
    {
        List<Employee> ListEmployees = new();
        //Get the Employees from the Database
        //for now we are hard coded the employees
        ListEmployees.Add(new Employee() { ID = 1, Name = "Sutter", Department = "IT" });
        ListEmployees.Add(new Employee() { ID = 2, Name = "Gisin", Department = "HR" });
        ListEmployees.Add(new Employee() { ID = 3, Name = "Däster", Department = "Payroll" });

        return ListEmployees;
    }
}
