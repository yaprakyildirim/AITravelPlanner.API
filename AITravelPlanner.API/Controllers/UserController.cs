using AITravelPlanner.API.Models.Requests;
using AITravelPlanner.API.Models.Responses;
using AITravelPlanner.Services.Services.Concrete;
using Microsoft.AspNetCore.Mvc;
using RegisterRequest = AITravelPlanner.API.Models.Requests.RegisterRequest;

namespace AITravelPlanner.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var user = await _userService.RegisterUserAsync(request.Name, request.SurName, request.UserName, request.Email, request.Password);
            return Ok(new UserResponse { Id = user.Id, Name = user.Name, SurName = user.SurName, UserName = user.UserName, Email = user.Email });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _userService.AuthenticateUserAsync(request.Email, request.Password);
            if (user == null) return Unauthorized("Geçersiz e-posta veya şifre");

            return Ok(new UserResponse { Id = user.Id, Name = user.Name, Email = user.Email });
        }
    }
}