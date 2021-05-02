using ApiPractice.DTOs.Favorite;
using ApiPractice.FromQueryString.Favorite;
using ApiPractice.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ApiPractice.Controllers.v1.Favorite
{
    [Authorize]
    [ApiController]
    [Route("api/v1/favorite/characters")]
    public class FavoriteCharactersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IFavoriteCharacterService _favoriteCharacterService;

        public FavoriteCharactersController(IMapper mapper, IUserService userService, IFavoriteCharacterService favoriteCharacterService)
        {
            _mapper = mapper;
            _userService = userService;
            _favoriteCharacterService = favoriteCharacterService;
        }

        [HttpGet]
        public IActionResult Find([FromQuery] FindFavoriteCharacterQueryString findFavoriteCharacterQueryString)
        {
            var user = _userService.FindByEmail(HttpContext.User.FindFirst(ClaimTypes.Email).Value);
            var favoriteCharacters = _favoriteCharacterService.Find(user, findFavoriteCharacterQueryString.Skip, findFavoriteCharacterQueryString.Take);

            if (favoriteCharacters == null || !favoriteCharacters.Any())
                return NotFound();
            
            return Ok(_mapper.Map<List<ResponseFavoriteCharacterDTO>>(favoriteCharacters));
        }
        
        [HttpPost]
        public IActionResult Create(CreateFavoriteCharacterDTO createFavoriteCharacterDto)
        {
            var favoriteCharacter = _mapper.Map<Entities.Favorite.FavoriteCharacter>(createFavoriteCharacterDto);

            if (_favoriteCharacterService.Create(favoriteCharacter))
                return Ok(_mapper.Map<ResponseFavoriteCharacterDTO>(favoriteCharacter));

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var user = _userService.FindByEmail(HttpContext.User.FindFirst(ClaimTypes.Email).Value);
            var favoriteCharacter = _favoriteCharacterService.FindById(user, id);

            if (favoriteCharacter == null)
                return NotFound();

            if (_favoriteCharacterService.Delete(favoriteCharacter))
                return Ok();

            return BadRequest();
        }
    }
}
