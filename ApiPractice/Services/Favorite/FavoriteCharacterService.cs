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
            => _favoriteCharacterRepository = favoriteCharacterRepository;

        public FavoriteCharacter FindById(Entities.User.User user, long id)
            => _favoriteCharacterRepository.FindById(user, id);
        
        public List<FavoriteCharacter> Find(Entities.User.User user, int skip, int take)
            => _favoriteCharacterRepository.Find(user, skip, take);
        
        public bool Create(FavoriteCharacter favoriteCharacter)
        {
            var foundCharacter = _favoriteCharacterRepository.FindByCharacterAndUser(favoriteCharacter.Character.Id, favoriteCharacter.User.Id);

            if (foundCharacter != null) return false;

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
