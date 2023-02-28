using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SqlDAL.Model
{
    [Table("dept")]
    public class InfrastructureDepartment
    {
        [Column("DEPTNO")]
        public int DepartmentNumber { get; set; }
        [Column("DNAME")]
        public string DepartmentName { get; set; } = default!;
        [Column("LOC")]
        public string Location { get; set; } = default!;
    }
}
