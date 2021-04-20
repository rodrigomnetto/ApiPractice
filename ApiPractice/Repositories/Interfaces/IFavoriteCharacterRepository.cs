using System.Collections.Generic;

namespace ApiPractice.Repositories.Interfaces
{
    public interface IFavoriteCharacterRepository
    {
        List<Entities.Favorite.FavoriteCharacter> Find(int skip, int take);

        void Create(Entities.Favorite.FavoriteCharacter favoriteCharacter);

        void Delete(Entities.Favorite.FavoriteCharacter favoriteCharacter);

        bool SaveChanges();
    }
}
