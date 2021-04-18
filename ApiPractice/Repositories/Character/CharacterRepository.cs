using ApiPractice.Contexts;
using ApiPractice.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ApiPractice.Repositories.Character
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ApiPracticeDbContext _dbContext;

        public CharacterRepository(ApiPracticeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Entities.Character.Character> FindCharacters(int skip, int take, string nameStartsWith)
        {
            IQueryable<Entities.Character.Character> query = _dbContext.Characters;

            if (nameStartsWith != null)
                query = query.Where(w => w.Name.ToLower().StartsWith(nameStartsWith.ToLower()));

            query = query.Skip(skip).Take(take).OrderBy(o => o.Name);

            return query.ToList();
        }

        public Entities.Character.Character FindById(long id)
            => _dbContext.Characters.SingleOrDefault(w => w.Id == id);
    }
}
