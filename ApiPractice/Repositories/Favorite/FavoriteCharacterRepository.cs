using ApiPractice.Contexts;
using ApiPractice.Entities.Favorite;
using ApiPractice.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ApiPractice.Repositories.Favorite
{
    public class FavoriteCharacterRepository : IFavoriteCharacterRepository
    {
        private readonly ApiPracticeDbContext _dbContext;

        public FavoriteCharacterRepository(ApiPracticeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<FavoriteCharacter> Find(int skip, int take)
        {
            return _dbContext.FavoriteCharacters.Skip(skip).Take(take).ToList();
        }

        public void Create(FavoriteCharacter favoriteCharacter)
        {
            _dbContext.FavoriteCharacters.Add(favoriteCharacter);
        }

        public void Delete(FavoriteCharacter favoriteCharacter)
        {
            _dbContext.FavoriteCharacters.Remove(favoriteCharacter);
        }

        public bool SaveChanges()
            => _dbContext.SaveChanges() > 0;
    }
}
