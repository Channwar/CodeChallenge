using Application.Extensions;
using Application.Model;

using Domain.Repositories;

namespace Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly Domain.Services.IEmployeeService employeeService;

        public EmployeeService(Domain.Services.IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employeeService.GetAllEmployee().ToApplicationEmployee();
        }

        public void SetNewManager(int idManager, int idEmployee)
        {
            employeeService.SetNewManager(idManager, idEmployee);
        }
    }
}
