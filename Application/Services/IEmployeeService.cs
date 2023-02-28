using Application.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAllEmployee();

        public void SetNewManager(int idManager, int idEmployee);
    }
}
