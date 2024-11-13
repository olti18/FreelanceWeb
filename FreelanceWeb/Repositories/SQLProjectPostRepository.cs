using FreelanceWeb.Data;
using FreelanceWeb.Model.Domain;

namespace FreelanceWeb.Repositories
{
    public class SQLProjectPostRepository : IProjectPostRepository
    {
        private readonly FreelanceWebDbContext _context;
        public SQLProjectPostRepository(FreelanceWebDbContext _context)
        {
            this._context = _context;
        }

        public async Task<ProjectPost> CreateAsync(ProjectPost projectPost)
        {
            await _context.AddAsync(projectPost);
            await _context.SaveChangesAsync();
            return projectPost;
        }
    }
}
