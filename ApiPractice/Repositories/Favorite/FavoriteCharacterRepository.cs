using ApiPractice.Contexts;
using ApiPractice.Entities.Favorite;
using ApiPractice.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiPractice.Repositories.Favorite
{
    public class FavoriteCharacterRepository : IFavoriteCharacterRepository
    {
        private readonly ApiPracticeDbContext _dbContext;

        public FavoriteCharacterRepository(ApiPracticeDbContext dbContext)
            => _dbContext = dbContext;
        
        public FavoriteCharacter FindById(Entities.User.User user, long id)
            => _dbContext.FavoriteCharacters.SingleOrDefault(s => s.User.Id == user.Id && s.Id == id);

        public FavoriteCharacter FindByCharacterAndUser(long characterId, long userId)
            => _dbContext.FavoriteCharacters.SingleOrDefault(s => s.User.Id == userId && s.Character.Id == characterId);

        public List<FavoriteCharacter> Find(Entities.User.User user, int skip, int take)
            => _dbContext.FavoriteCharacters.Where(w => w.User.Id == user.Id).Skip(skip).Take(take).Include(nameof(FavoriteCharacter.Character)).ToList();
        
        public void Create(FavoriteCharacter favoriteCharacter)
        {
            _dbContext.Entry(favoriteCharacter.User).State = EntityState.Unchanged;
            _dbContext.Entry(favoriteCharacter.Character).State = EntityState.Unchanged;
            _dbContext.FavoriteCharacters.Add(favoriteCharacter);
        }

        public void Delete(FavoriteCharacter favoriteCharacter)
            => _dbContext.FavoriteCharacters.Remove(favoriteCharacter);

        public bool SaveChanges()
            => _dbContext.SaveChanges() > 0;
    }
}
