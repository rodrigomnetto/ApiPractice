using ApiPractice.DTOs.Character;
using AutoMapper;

namespace ApiPractice.Maps.Character
{
    public class CharacterToCharacterResponseDTO : Profile
    {
        public CharacterToCharacterResponseDTO()
        {
            CreateMap<Entities.Character.Character, CharacterResponseDTO>();
        }
    }
}
