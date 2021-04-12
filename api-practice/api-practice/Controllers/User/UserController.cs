using ApiPractice.DTOs.User;
using ApiPractice.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiPractice.Controllers.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        //implementar find com paginacao, ver videos, query params

        [HttpGet]
        [Route("{id}")]
        [Authorize]
        public IActionResult FindById(long id)
        {
            var user =_userService.FindById(id);
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
        [Route("/{id}")]
        [Authorize]
        public IActionResult Update(long id, UpdateUserDTO updateUserDto)
        {
            var user = _mapper.Map<Entities.User.User>(updateUserDto);

            if (_userService.Update(id, user))
            {
                var userResponse = _mapper.Map<UserResponseDTO>(user);
                return Ok(userResponse);
            }

            return BadRequest();
        }

        [HttpDelete]
        [Route("/{id}")]
        [Authorize]
        public IActionResult Delete(long id)
        {
            if (_userService.Delete(id))
                return Ok();

            return BadRequest();
        }
    }
}
