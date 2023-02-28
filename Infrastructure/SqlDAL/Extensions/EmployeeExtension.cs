using Infrastructure.SqlDAL.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SqlDAL.Extensions
{
    internal static class EmployeeExtension
    {
        public static Domain.Model.DomainEmployee ToDomainEmployee(this Infrastructure.SqlDAL.Model.InfrastructureEmployee employee)
        {
            var empResult =  new Domain.Model.DomainEmployee()
            {
                Commission = employee.Commission,
                Department = employee.Department.ToDomainDepartment(),
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
                empResult.Manager = employee.Manager.ToDomainEmployee();
                return empResult;
            }
        }

        public static Infrastructure.SqlDAL.Model.InfrastructureEmployee ToInfrastructureEmployee(this Domain.Model.DomainEmployee employee)
        {
            var empResult = new Infrastructure.SqlDAL.Model.InfrastructureEmployee()
            {
                Commission = employee.Commission,
                Department = employee.Department.ToInfrastructureDepartment(),
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
                empResult.Manager = employee.Manager.ToInfrastructureEmployee();
                return empResult;
            }
        }

        public static IEnumerable<Domain.Model.DomainEmployee> ToDomainEmployee(this IEnumerable<Infrastructure.SqlDAL.Model.InfrastructureEmployee> employees)
        {
            return employees.Select(ToDomainEmployee);
        }

        public static IEnumerable<Infrastructure.SqlDAL.Model.InfrastructureEmployee> ToInfrastructureEmployee(this IEnumerable<Domain.Model.DomainEmployee> employees)
        {
            return employees.Select(ToInfrastructureEmployee);
        }
    }
}
