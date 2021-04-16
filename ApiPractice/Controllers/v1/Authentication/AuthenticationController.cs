using ApiPractice.DTOs.Authentication;
using ApiPractice.Identity.Services.Interfaces;
using ApiPractice.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiPractice.Controllers.v1.Authentication
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;

        public AuthenticationController(IAuthenticationService authenticationService, IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Authenticate(AuthenticateUserDTO authenticateUserDto)
        {
            var user = _userService.FindByEmailPassword(authenticateUserDto.Email, authenticateUserDto.Password);

            if (user == null)
                return Forbid();

            var token = _authenticationService.GenerateToken(user);

            return Ok(new { Token = token });
        }
    }
}
