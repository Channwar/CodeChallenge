using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SqlDAL.Model
{
    [Table("emp")]
    public class InfrastructureEmployee
    {
        [Column("EMPNO")]
        public int EmployeeNumber { get; set; }
        [Column("ENAME")]
        public string EmployeeName { get; set; } = default!;
        [Column("JOB")]
        public string Job { get; set; } = default!;
        [Column("MGR")]
        public InfrastructureEmployee? Manager { get; set; }
        [Column("HIREDATE")]
        public DateTime HireDate { get; set; }
        [Column("SAL")]
        public int Salary { get; set; }
        [Column("COMM")]
        public int? Commission { get; set; }
        [Column("DEPTNO")]
        public InfrastructureDepartment Department { get; set; } = default!;
    }
}
