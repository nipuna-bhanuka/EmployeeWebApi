using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWebApi.Models;

namespace EmployeeWebApi.Services
{
    public class EmployeeService
    {
        //getEmployee
        public List<Employee> AllEmployees()
        {
            var employees = new List<Employee>();

            var employee1 = new Employee
            {
                EmployeeID = 1,
                EmployeeName = "Nipuna",
                EmployeeAge = 25,
                EmployeeSalary = 1000

            };
            employees.Add(employee1);

            var employee2 = new Employee
            {
                EmployeeID = 2,
                EmployeeName = "Minura",
                EmployeeAge = 20,
                EmployeeSalary = 1000

            };
            employees.Add(employee2);

            var employee3 = new Employee
            {
                EmployeeID = 3,
                EmployeeName = "Smitha",
                EmployeeAge = 25,
                EmployeeSalary = 1000

            };
            employees.Add(employee3);

            return employees;
        }
    }
}
