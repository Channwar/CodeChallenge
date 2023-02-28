
namespace Application.Model
{
    public class Project
    {
        public int ProjectId { get; set; }
        public Employee Employee { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
