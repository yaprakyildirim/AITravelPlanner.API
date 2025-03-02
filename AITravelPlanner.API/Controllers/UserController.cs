using AITravelPlanner.API.Models.Requests;
using AITravelPlanner.API.Models.Responses;
using AITravelPlanner.Services.Services.Abstract;
using AITravelPlanner.Services.Services.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using RegisterRequest = AITravelPlanner.API.Models.Requests.RegisterRequest;

namespace AITravelPlanner.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
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

            var token = await _userService.GenerateJwtToken(user);
            return Ok(new { Token = token });
        }

        [HttpGet("GetByUserId")]
        public async Task<IActionResult> GetUserInfo()
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)!.Value);
            var user = await _userService.GetUserByIdAsync(userId);

            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            return Ok(new UserResponse { Id = user.Id, Name = user.Name, Email = user.Email });
        }
    }
}