using ApiPractice.DTOs.Favorite;
using ApiPractice.Entities.Favorite;
using ApiPractice.Services.Interfaces;
using AutoMapper;

namespace ApiPractice.Maps.Favorite.PropertyResolver
{
    public class CharacterResolver : IValueResolver<CreateFavoriteCharacterDTO, FavoriteCharacter, Entities.Character.Character>
    {
        private ICharacterService _characterService;

        public CharacterResolver(ICharacterService characterService)
            => _characterService = characterService;
       
        public Entities.Character.Character Resolve(CreateFavoriteCharacterDTO source, FavoriteCharacter destination, Entities.Character.Character destMember, ResolutionContext context)
            => _characterService.FindById(source.CharacterId);
    }
}
