using ApiPractice.DTOs.User;
using ApiPractice.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApiPractice.Controllers.v1.User
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Find()
        {
            var user = _userService.FindByEmail(HttpContext.User.FindFirst(ClaimTypes.Email).Value);

            if (user == null)
                return NotFound();
            
            return Ok(_mapper.Map<UserResponseDTO>(user));
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Create(CreateUserDTO createUserDto)
        {
            var user = _mapper.Map<Entities.User.User>(createUserDto);

            if (_userService.Create(user))
                return Ok(_mapper.Map<UserResponseDTO>(user));
            
            return BadRequest();
        }

        [HttpPut]
        [Authorize]
        public IActionResult Update(UpdateUserDTO updateUserDto)
        {
            var user = _userService.FindByEmail(HttpContext.User.FindFirst(ClaimTypes.Email).Value);
            var updatedUser = _mapper.Map<Entities.User.User>(updateUserDto);

            if (_userService.Update(user, updatedUser))
                return Ok(_mapper.Map<UserResponseDTO>(user));
            
            return BadRequest();
        }
    }
}
