using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace AITravelPlanner.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest model)
        {
            return Ok(new { message = "Kullanıcı başarıyla kaydedildi!" });
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest model)
        {
            return Ok(new { token = "fake-jwt-token" });
        }

        [HttpGet("profile")]
        public IActionResult GetUserProfile()
        {
            return Ok(new { id = 1, name = "Yaprak Yıldırım", email = "yaprak@ai.com" });
        }
    }
}