using ApiPractice.DTOs.Character;
using ApiPractice.FromQueryString.Character;
using ApiPractice.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ApiPractice.Controllers.v1.Character
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICharacterService _characterService;

        public CharactersController(IMapper mapper, ICharacterService characterService)
        {
            _mapper = mapper;
            _characterService = characterService;
        }

        [HttpGet]
        public IActionResult Find([FromQuery] FindCharacterQueryString findCharacterQuery)
        {
            var characters = _characterService.FindCharacters(findCharacterQuery.Skip, findCharacterQuery.Take, findCharacterQuery.NameStartsWith);

            if (characters == null || !characters.Any())
                return NotFound();

            return Ok(_mapper.Map<List<CharacterResponseDTO>>(characters));
        }

        [HttpGet("{id}")]
        public IActionResult FindById(long id)
        {
            var character = _characterService.FindById(id);

            if (character == null)
                return NotFound();

            return Ok(_mapper.Map<CharacterResponseDTO>(character));
        }
    }
}
