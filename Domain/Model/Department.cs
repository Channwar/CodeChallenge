namespace Domain.Model
{
    public class DomainDepartment
    {
        public int DepartmentNumber { get; set; }
        public string DepartmentName { get; set; } = default!;
        public string Location { get; set; } = default!;
    }
}
