using Domain.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IEmployeeRepository
    {
        public IEnumerable<DomainEmployee> GetAllEmployee();

        public DomainEmployee? GetEmployeeById(int idEmployee);

        public void UpdateEmployee(DomainEmployee employee);
    }
}
