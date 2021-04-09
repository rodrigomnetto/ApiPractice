using ApiPractice.DbContexts;
using ApiPractice.Repositories.Interfaces;

namespace ApiPractice.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiPracticeDbContext _dbContext;

        public UserRepository(ApiPracticeDbContext dbContext)
            => _dbContext = dbContext;
        
        public void Save(Entities.User.User user)
        {
            _dbContext.User.Add(user);
            _dbContext.SaveChanges();
        }

        public void Update(Entities.User.User user)
        {
            _dbContext.User.Update(user);
            _dbContext.SaveChanges();
        }

        public void Delete(Entities.User.User user)
        {
            _dbContext.User.Remove(user);
            _dbContext.SaveChanges();
        }

        public Entities.User.User FindById(long id)
            => _dbContext.User.Find(id);
    }
}
