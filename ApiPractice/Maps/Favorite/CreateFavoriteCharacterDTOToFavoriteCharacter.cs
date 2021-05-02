using ApiPractice.DTOs.Favorite;
using ApiPractice.Maps.Favorite.PropertyResolver;
using AutoMapper;

namespace ApiPractice.Maps.Favorite
{
    public class CreateFavoriteCharacterDTOToFavoriteCharacter : Profile
    {
        public CreateFavoriteCharacterDTOToFavoriteCharacter()
        {
            CreateMap<CreateFavoriteCharacterDTO, Entities.Favorite.FavoriteCharacter>()
                .ForMember(obj => obj.User, exp => exp.MapFrom<UserResolver>())
                .ForMember(obj => obj.Character, exp => exp.MapFrom<CharacterResolver>());
        }
    }
}
