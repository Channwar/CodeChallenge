namespace Application.Extensions
{
    internal static class DepartmentExtension
    {
        public static Application.Model.Department ToApplicationDepartment(this Domain.Model.DomainDepartment department)
        {
            return new Application.Model.Department()
            {
                DepartmentName = department.DepartmentName,
                DepartmentNumber = department.DepartmentNumber,
                Location = department.Location
            };
        }

        public static IEnumerable<Application.Model.Department> ToApplicationDepartment(this IEnumerable<Domain.Model.DomainDepartment> departments)
        {
            return departments.Select(ToApplicationDepartment);
        }
    }
}
