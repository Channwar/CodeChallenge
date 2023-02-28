using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SqlDAL.Model
{
    [Table("proj")]
    public class InfrastructureProject
    {
        [Column("PROJID")]
        public int ProjectId { get; set; }
        [Column("EMPNO")]
        public InfrastructureEmployee Employee { get; set; } = default!;
        [Column("STARTDATE")]
        public DateTime StartDate { get; set; }
        [Column("ENDDATE")]
        public DateTime EndDate { get; set; }
    }
}
