using ApiPractice.DTOs.Favorite;
using ApiPractice.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApiPractice.Controllers.v1.Favorite
{
    [ApiController]
    [Route("api/v1/favorite/characters")]
    public class FavoriteCharactersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly ICharacterService _characterService;

        public FavoriteCharactersController(IMapper mapper, IUserService userService, ICharacterService characterService)
        {
            _mapper = mapper;
            _userService = userService;
            _characterService = characterService;
        }

        /*public IActionResult Find()
        {

        }*/

        [HttpPost]
        public IActionResult Create(CreateFavoriteCharacterDTO createFavoriteCharacterDto)
        {
            var user = _userService.FindByEmail(HttpContext.User.FindFirst(ClaimTypes.Email).Value);
            var character = _characterService.FindById(createFavoriteCharacterDto.CharacterId);



            return null;
        }

        /*public IActionResult Delete()
        {

        }*/
    }
}
