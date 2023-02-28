using Domain.Model;
using Domain.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    internal class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IEnumerable<DomainEmployee> GetAllEmployee()
        {
            return employeeRepository.GetAllEmployee();
        }

        public void SetNewManager(int idManager, int idEmployee)
        {
            var employee = employeeRepository.GetEmployeeById(idEmployee);
            var newManager = employeeRepository.GetEmployeeById(idManager);

            if (employee is not null && newManager is not null)
            {
                employee.Manager= newManager;
                employeeRepository.UpdateEmployee(employee);
            }
            else
            {
                throw new Exception("employee or manager not found");
            }
        }
    }
}
