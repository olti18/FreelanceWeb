
namespace FreelanceWeb.Model.DTO
{
    public class ProjectPostDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Budget { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime Deadline { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
    }
}
