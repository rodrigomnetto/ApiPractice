using ApiPractice.Repositories.Interfaces;
using ApiPractice.Services.Interfaces;

namespace ApiPractice.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            => _userRepository = userRepository;

        public void Save(Entities.User.User user)
            => _userRepository.Save(user);

        public void Update(long id, Entities.User.User updateUser)
        {
            var user = _userRepository.FindById(id);
            user.Name = updateUser.Name;

            _userRepository.Update(user);
        }

        public void Delete(long id)
        {
            var user = _userRepository.FindById(id);
            _userRepository.Delete(user);
        }

        public Entities.User.User FindById(long id)
            => _userRepository.FindById(id);
    }
}
