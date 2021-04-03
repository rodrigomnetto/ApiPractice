using ApiPractice.DTOs.User;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiPractice.Controllers.User
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public StatusCodeResult Save(SaveUserDTO SaveUserDto)
        {
            var user = _mapper.Map<Entities.User>(SaveUserDto);


            return Ok();
        }
        
        

    }
}
