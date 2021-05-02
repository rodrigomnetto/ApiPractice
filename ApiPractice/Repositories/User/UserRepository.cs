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
            => _dbContext.Users.Add(user);

        public void Update(Entities.User.User user)
            => _dbContext.Users.Update(user);

        public void Delete(Entities.User.User user)
            => _dbContext.Users.Remove(user);

        public Entities.User.User FindByEmailPassword(string email, string password)
            => _dbContext.Users.SingleOrDefault(w => w.Email == email && w.Password == password);

        public Entities.User.User FindByEmail(string email)
            => _dbContext.Users.SingleOrDefault(w => w.Email == email);

        public bool SaveChanges()
            => _dbContext.SaveChanges() > 0;
    }
}
