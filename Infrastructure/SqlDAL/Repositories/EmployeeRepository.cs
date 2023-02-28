using Domain.Model;
using Domain.Repositories;

using Infrastructure.SqlDAL.Extensions;
using Infrastructure.SqlDAL.Model;

using Org.BouncyCastle.Math.EC;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SqlDAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CodeChallengeDbContext codeChallengeDbContext;

        public EmployeeRepository(CodeChallengeDbContext codeChallengeDbContext)
        {
            this.codeChallengeDbContext = codeChallengeDbContext;
        }

        public IEnumerable<Domain.Model.DomainEmployee> GetAllEmployee()
        {
            return codeChallengeDbContext.EmployeeDbSet.Select(e => e.ToDomainEmployee());
        }

        public DomainEmployee? GetEmployeeById(int idEmployee)
        {
            var employee = codeChallengeDbContext.EmployeeDbSet.FirstOrDefault(e => e.EmployeeNumber == idEmployee);
            

            return employee is null ? null : employee.ToDomainEmployee();
        }

        public void UpdateEmployee(DomainEmployee employee)
        {
            var infraEmployee = employee.ToInfrastructureEmployee();
            var empSql = codeChallengeDbContext.EmployeeDbSet.FirstOrDefault(e => e.EmployeeNumber == employee.EmployeeNumber);

            empSql = infraEmployee;

            codeChallengeDbContext.SaveChanges();
        }
    }
}
