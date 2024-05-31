using Microsoft.AspNetCore.Mvc;

namespace GalacticMiningBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost("SignIn")]
        public IActionResult SignIn([FromBody] SignInRequest request)
        {
            if (request.username == "test" && request.password == "password")
            {
                return Ok(new { message = "Sign-in successful" });
            }
            return Unauthorized(new { message = "Invalid username or password" });
        }

        [HttpPost("LogIn")]
        public IActionResult LogIn([FromBody] LogInRequest request)
        {
            if (request.username == "test" && request.password == "password")
            {
                return Ok(new { message = "Log-in successful" });
            }
            return Unauthorized(new { message = "Invalid username or password" });
        }
    }

    public class SignInRequest
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class LogInRequest
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}