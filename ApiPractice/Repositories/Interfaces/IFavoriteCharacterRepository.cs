using System.Collections.Generic;

namespace ApiPractice.Repositories.Interfaces
{
    public interface IFavoriteCharacterRepository
    {
        Entities.Favorite.FavoriteCharacter FindById(Entities.User.User user, long id);

        List<Entities.Favorite.FavoriteCharacter> Find(Entities.User.User user, int skip, int take);

        Entities.Favorite.FavoriteCharacter FindByCharacterAndUser(long characterId, long userId);

        void Create(Entities.Favorite.FavoriteCharacter favoriteCharacter);

        void Delete(Entities.Favorite.FavoriteCharacter favoriteCharacter);

        bool SaveChanges();
    }
}
