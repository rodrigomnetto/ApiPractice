using ApiPractice.Repositories.Interfaces;
using ApiPractice.Services.Interfaces;

namespace ApiPractice.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            => _userRepository = userRepository;

        public bool Create(Entities.User.User user)
        {
            _userRepository.Create(user);
            return _userRepository.SaveChanges();
        }

        public bool Update(long id, Entities.User.User updateUser)
        {
            var user = _userRepository.FindById(id);
            user.Name = updateUser.Name;

            _userRepository.Update(user);
            return _userRepository.SaveChanges();
        }

        public bool Delete(long id)
        {
            var user = _userRepository.FindById(id);

            _userRepository.Delete(user);
            return _userRepository.SaveChanges();
        }

        public Entities.User.User FindById(long id)
            => _userRepository.FindById(id);

        public Entities.User.User FindByEmailPassword(string email, string password)
            => _userRepository.FindByEmailPassword(email, password);
    }
}
