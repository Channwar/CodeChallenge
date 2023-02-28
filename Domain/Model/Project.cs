
namespace Domain.Model
{
    public class DomainProject
    {
        public int ProjectId { get; set; }
        public DomainEmployee Employee { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
