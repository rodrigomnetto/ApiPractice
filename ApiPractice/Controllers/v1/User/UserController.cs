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

        //implementar find com paginacao, ver videos, query params, fazer a entidade de favorite_jobs do usuario

        [HttpGet]
        [Authorize]
        public IActionResult Find()
        {
            var user = _userService.FindByEmail(HttpContext.User.FindFirst(ClaimTypes.Email).Value);
            var userResponse = _mapper.Map<UserResponseDTO>(user);
            
            if (userResponse == null)
                return NotFound();

            return Ok(userResponse);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Create(CreateUserDTO createUserDto)
        {
            var user = _mapper.Map<Entities.User.User>(createUserDto);

            if (_userService.Create(user))
            {
                var userResponse = _mapper.Map<UserResponseDTO>(user);
                return Ok(userResponse);
            }

            return BadRequest();
        }

        [HttpPut]
        [Authorize]
        public IActionResult Update(UpdateUserDTO updateUserDto)
        {
            var user = _userService.FindByEmail(HttpContext.User.FindFirst(ClaimTypes.Email).Value);
            var updatedUser = _mapper.Map<Entities.User.User>(updateUserDto);

            if (_userService.Update(user, updatedUser))
            {
                var userResponse = _mapper.Map<UserResponseDTO>(user);
                return Ok(userResponse);
            }

            return BadRequest();
        }
    }
}
