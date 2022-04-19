using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DependencyInjection;

public class EmployeeBL
{
    private readonly IEmployeeDAL _employeeDAL;
    public EmployeeBL(IEmployeeDAL employeeDAL) => _employeeDAL = employeeDAL;
    
    public List<Employee> GetAllEmployees() =>_employeeDAL.SelectAllEmployees();
}