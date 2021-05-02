using System.Collections.Generic;

namespace ApiPractice.Services.Interfaces
{
    public interface IFavoriteCharacterService
    {
        Entities.Favorite.FavoriteCharacter FindById(Entities.User.User user, long id);

        List<Entities.Favorite.FavoriteCharacter> Find(Entities.User.User user, int skip, int take);

        bool Create(Entities.Favorite.FavoriteCharacter favoriteCharacter);

        bool Delete(Entities.Favorite.FavoriteCharacter favoriteCharacter);
    }
}
