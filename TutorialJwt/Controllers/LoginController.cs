using Microsoft.AspNetCore.Mvc;
using TutorialJwt.Interfaces;

namespace TutorialJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJwtService _jwtService;

        public LoginController(IUserService userService, IJwtService jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }

        [HttpPost]
        public IActionResult Authenticate(LoginRequest loginRequest)
        {
            var user = _userService.GetUser(loginRequest.Login, loginRequest.Password);
            if (user == null) return BadRequest();

            var token = _jwtService.GenerateToken(user);
            return Ok(token);
        }
    }

    public class LoginRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
