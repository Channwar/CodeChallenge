namespace Application.Extensions
{
    internal static class EmployeeExtension
    {
        public static Application.Model.Employee ToApplicationEmployee(this Domain.Model.DomainEmployee employee)
        {
            var empResult =  new Application.Model.Employee()
            {
                Commission = employee.Commission,
                Department = employee.Department.ToApplicationDepartment(),
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
                empResult.Manager = employee.Manager.ToApplicationEmployee();
                return empResult;
            }
        }

        public static IEnumerable<Application.Model.Employee> ToApplicationEmployee(this IEnumerable<Domain.Model.DomainEmployee> employees)
        {
            return employees.Select(ToApplicationEmployee);
        }
    }
}
