using AutoMapper;
using FreelanceWeb.Model.Domain;
using FreelanceWeb.Model.DTO;

namespace FreelanceWeb.Mappings
{
    public class AutoMapperProfiles: Profile 
    {
        public AutoMapperProfiles()
        {
            CreateMap<AddProjectPostRequestDto, ProjectPost>().ReverseMap();
            CreateMap<ProjectPost, ProjectPostDto>().ReverseMap();
        }
    }
}
