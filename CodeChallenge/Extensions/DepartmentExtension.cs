using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Extensions
{
    internal static class DepartmentExtension
    {
        public static Models.Department ToControllerDepartment(this Application.Model.Department department)
        {
            return new Models.Department()
            {
                DepartmentName = department.DepartmentName,
                DepartmentNumber = department.DepartmentNumber,
                Location = department.Location
            };
        }

        public static IEnumerable<Models.Department> ToControllerDepartment(this IEnumerable<Application.Model.Department> departments)
        {
            return departments.Select(ToControllerDepartment);
        }
    }
}
