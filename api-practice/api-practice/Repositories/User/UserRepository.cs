using ApiPractice.Contexts;
using ApiPractice.Repositories.Interfaces;
using System.Linq;

namespace ApiPractice.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiPracticeDbContext _dbContext;

        public UserRepository(ApiPracticeDbContext dbContext)
            => _dbContext = dbContext;
        
        public void Create(Entities.User.User user)
        {
            _dbContext.User.Add(user);
        }

        public void Update(Entities.User.User user)
        {
            _dbContext.User.Update(user);
        }

        public void Delete(Entities.User.User user)
        {
            _dbContext.User.Remove(user);
        }

        public Entities.User.User FindById(long id)
            => _dbContext.User.Find(id);

        public Entities.User.User FindByEmailPassword(string email, string password)
            => _dbContext.User.SingleOrDefault(w => w.Email == email && w.Password == password);
        
        public bool SaveChanges()
            => _dbContext.SaveChanges() > 0;
    }
}
