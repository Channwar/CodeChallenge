using Infrastructure.SqlDAL.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Extensions
{
    internal static class EmployeeExtension
    {
        public static Models.Employee ToControllerEmployee(this Application.Model.Employee employee)
        {
            var empResult =  new Models.Employee()
            {
                Commission = employee.Commission,
                Department = employee.Department.ToControllerDepartment(),
                EmployeeName = employee.EmployeeName,
                EmployeeNumber = employee.EmployeeNumber,
                HireDate = employee.HireDate,
                Job = employee.Job,
                Manager = null,
                Salary = employee.Salary
            };

            if (employee.Manager == null) 
            {
                return empResult;
            }
            else
            {
                empResult.Manager = employee.Manager.ToControllerEmployee();
                return empResult;
            }
        }

        public static IEnumerable<Models.Employee> ToControllerEmployee(this IEnumerable<Application.Model.Employee> employees)
        {
            return employees.Select(ToControllerEmployee);
        }
    }
}
