namespace Domain.Model
{
    public class DomainEmployee
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; } = default!;
        public string Job { get; set; } = default!;
        public DomainEmployee? Manager { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public int? Commission { get; set; }
        public DomainDepartment Department { get; set; } = default!;
    }
}
