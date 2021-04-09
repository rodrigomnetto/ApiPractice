using ApiPractice.DTOs.User;
using ApiPractice.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiPractice.Controllers.User
{
    [ApiController]
    [Route("[controller]")]
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
        [Route("/{id}")]
        public IActionResult FindById(long id)
        {
            var user =_userService.FindById(id);
            var userResponse = _mapper.Map<UserResponseDTO>(user);

            return Ok(userResponse);
        }

        [HttpPost]
        public IActionResult Save(SaveUserDTO saveUserDto)
        {
            var user = _mapper.Map<Entities.User.User>(saveUserDto);
            _userService.Save(user);

            return Ok();
        }

        [HttpPut]
        [Route("/{id}")]
        public IActionResult Update(long id, UpdateUserDTO updateUserDto)
        {
            var user = _mapper.Map<Entities.User.User>(updateUserDto);
            _userService.Update(id, user);

            return Ok();
        }

        [HttpDelete]
        [Route("/{id}")]
        public IActionResult Delete(long id)
        {
            _userService.Delete(id);

            return Ok();
        }
    }
}
