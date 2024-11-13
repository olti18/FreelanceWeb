namespace FreelanceWeb.Model.Domain
{
    public class ProjectPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Budget { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime Deadline { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }


        public string UserEmail { get; set; }  // Store the email of the user
        public string UserId { get; set; }     // Store the user ID (optional)
    }
}
