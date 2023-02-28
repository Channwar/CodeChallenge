namespace Application.Model
{
    public class Employee
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; } = default!;
        public string Job { get; set; } = default!;
        public Employee? Manager { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public int? Commission { get; set; }
        public Department Department { get; set; } = default!;
    }
}
