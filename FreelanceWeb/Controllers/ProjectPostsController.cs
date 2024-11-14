using AutoMapper;
using FreelanceWeb.Model.Domain;
using FreelanceWeb.Model.DTO;
using FreelanceWeb.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FreelanceWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectPostsController : ControllerBase
    {
        /*private readonly UserManager<IdentityUser> userManager;
        private readonly IProjectPostRepository projectPostRepository;
        public ProjectPostsController(UserManager<IdentityUser> userManager) 
        { 
            this.userManager = userManager;
        }


        [HttpGet]
        [Route("Get User")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> TestWithGetUserAsync()
        {
            var user = await userManager.GetUserAsync(User);

            if (user == null)
            {
                return Unauthorized("User not found.");
            }

            return Ok(new { UserId = user.Id, Email = user.Email });
        }*/
        private readonly ILogger<ProjectPostsController> _logger;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IMapper mapper;
        private readonly IProjectPostRepository projectPostRepository;

        public ProjectPostsController(ILogger<ProjectPostsController> logger, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            this._logger = logger;
            this.userManager = userManager;
            this.mapper = mapper;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUserId()
        {
            // Get the user from UserManager
            var user = await userManager.GetUserAsync(User);

            if (user == null)
            {
                return Unauthorized("User not found.");
            }
            var id = user.Id;
            // Return the User ID
            return Ok(new { UserId = user.Id });
        }

        /*[HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetProjectPosts()
        {
            var emailClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            if (string.IsNullOrEmpty(emailClaim))
            {
                return Ok("Email claim not found.");
            }


            return Ok("Success");
        }*/

        /*[HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetUserId()
        {
            // Get the user's ID from the claims
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userIdClaim))
            {
                return Unauthorized("User ID claim not found.");
            }

            return Ok(new { UserId = userIdClaim });
        }*/
        /*[HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetUserClaims()
        {
            var claims = User.Claims.Select(c => new { c.Type, c.Value }).ToList();
            return Ok(claims);
        }*/




        /*[HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetProjectPosts()
        {
            var emailClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            // Log all claims for debugging purposes
            var claims = User.Claims.Select(c => new { c.Type, c.Value }).ToList();
            foreach (var claim in claims)
            {
                Console.WriteLine($"Claim Type: {claim.Type}, Claim Value: {claim.Value}");
            }

            if (string.IsNullOrEmpty(emailClaim))
            {
                return Ok("Email claim not found.");
            }

            return Ok($"Email claim found: {emailClaim}");
        }*/
    }




    /*[HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create([FromBody] AddProjectPostRequestDto addProjectPostRequestDto)
    {
        // Get the current user
        var user = await userManager.GetUserAsync(User);

        // Map the DTO to the domain model
        var projectPostDomainModel = mapper.Map<ProjectPost>(addProjectPostRequestDto);

        // Set the email of the user who created the project post
        projectPostDomainModel.UserEmail = user?.Email;

        // Optionally, you can set the UserId if you want to store the user's ID
        // projectPostDomainModel.UserId = user?.Id;

        // Save the project post
        await projectPostRepository.CreateAsync(projectPostDomainModel);

        // Return the mapped DTO for the project post
        return Ok(mapper.Map<ProjectPostDto>(projectPostDomainModel));
    }
    */


}
