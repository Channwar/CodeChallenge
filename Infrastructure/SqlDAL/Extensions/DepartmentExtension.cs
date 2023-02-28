using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SqlDAL.Extensions
{
    internal static class DepartmentExtension
    {
        public static Domain.Model.DomainDepartment ToDomainDepartment(this Infrastructure.SqlDAL.Model.InfrastructureDepartment department)
        {
            return new Domain.Model.DomainDepartment()
            {
                DepartmentName = department.DepartmentName,
                DepartmentNumber = department.DepartmentNumber,
                Location = department.Location
            };
        }

        public static Infrastructure.SqlDAL.Model.InfrastructureDepartment ToInfrastructureDepartment(this Domain.Model.DomainDepartment department)
        {
            return new Infrastructure.SqlDAL.Model.InfrastructureDepartment()
            {
                DepartmentName = department.DepartmentName,
                DepartmentNumber = department.DepartmentNumber,
                Location = department.Location
            };
        }

        public static IEnumerable<Domain.Model.DomainDepartment> ToDomainDepartment(this IEnumerable<Infrastructure.SqlDAL.Model.InfrastructureDepartment> departments)
        {
            return departments.Select(ToDomainDepartment);
        }

        public static IEnumerable<Infrastructure.SqlDAL.Model.InfrastructureDepartment> ToInfrastructureDepartment(this IEnumerable<Domain.Model.DomainDepartment> departments)
        {
            return departments.Select(ToInfrastructureDepartment);
        }
    }
}
