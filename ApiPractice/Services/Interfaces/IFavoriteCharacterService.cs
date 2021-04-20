using System.Collections.Generic;

namespace ApiPractice.Services.Interfaces
{
    public interface IFavoriteCharacterService
    {
        List<Entities.Favorite.FavoriteCharacter> Find(int skip, int take);

        bool Create(Entities.Favorite.FavoriteCharacter favoriteCharacter);

        bool Delete(Entities.Favorite.FavoriteCharacter favoriteCharacter);
    }
}
