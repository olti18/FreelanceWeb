using FreelanceWeb.Model.Domain;

namespace FreelanceWeb.Repositories
{
    public interface IProjectPostRepository
    {
        Task<ProjectPost> CreateAsync(ProjectPost projectPost);
    }
}
