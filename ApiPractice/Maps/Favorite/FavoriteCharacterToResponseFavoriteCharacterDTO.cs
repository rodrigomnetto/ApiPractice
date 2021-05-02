using ApiPractice.DTOs.Favorite;
using AutoMapper;

namespace ApiPractice.Maps.Favorite
{
    public class FavoriteCharacterToResponseFavoriteCharacterDTO : Profile
    {
        public FavoriteCharacterToResponseFavoriteCharacterDTO()
            => CreateMap<Entities.Favorite.FavoriteCharacter, ResponseFavoriteCharacterDTO>();
    }
}
