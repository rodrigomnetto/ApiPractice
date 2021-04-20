using ApiPractice.Entities.Favorite;
using ApiPractice.Repositories.Interfaces;
using ApiPractice.Services.Interfaces;
using System.Collections.Generic;

namespace ApiPractice.Services.Favorite
{
    public class FavoriteCharacterService : IFavoriteCharacterService
    {
        private readonly IFavoriteCharacterRepository _favoriteCharacterRepository;

        public FavoriteCharacterService(IFavoriteCharacterRepository favoriteCharacterRepository)
        {
            _favoriteCharacterRepository = favoriteCharacterRepository;
        }

        public List<FavoriteCharacter> Find(int skip, int take)
        {
            return _favoriteCharacterRepository.Find(skip, take);
        }

        public bool Create(FavoriteCharacter favoriteCharacter)
        {
            _favoriteCharacterRepository.Create(favoriteCharacter);

            return _favoriteCharacterRepository.SaveChanges();
        }

        public bool Delete(FavoriteCharacter favoriteCharacter)
        {
            _favoriteCharacterRepository.Delete(favoriteCharacter);

            return _favoriteCharacterRepository.SaveChanges();
        }
    }
}
