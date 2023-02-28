using Domain.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IEmployeeService
    {
        public IEnumerable<DomainEmployee> GetAllEmployee();

        public void SetNewManager(int idManager, int idEmployee);
    }
}
