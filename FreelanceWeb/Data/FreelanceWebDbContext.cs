using FreelanceWeb.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace FreelanceWeb.Data
{
    public class FreelanceWebDbContext: DbContext
    {
        public FreelanceWebDbContext(DbContextOptions<FreelanceWebDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        DbSet<ProjectPost> ProjectPosts { get; set; }
    }
}
