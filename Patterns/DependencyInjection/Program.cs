﻿// See https://aka.ms/new-console-template for more information

using DesignPatterns.DependencyInjection;

EmployeeBL employeeBL = new(new EmployeeDAL());
List<Employee> ListEmployee = employeeBL.GetAllEmployees();

foreach (Employee emp in ListEmployee)
{
    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
}
