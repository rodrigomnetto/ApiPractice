using ApiPractice.Repositories.Interfaces;
using ApiPractice.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ApiPractice.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            => _userRepository = userRepository;

        public bool Create(Entities.User.User user)
        {
            var existingUser = _userRepository.FindByEmail(user.Email);

            if (existingUser != null) return false;

            _userRepository.Create(user);
            return _userRepository.SaveChanges();
        }

        public bool Update(Entities.User.User user, Entities.User.User updateUser)
        {
            user.Name = updateUser.Name;

            var q = new List<Entities.User.User>().Where(w => w.Email == "");

            _userRepository.Update(user);
            return _userRepository.SaveChanges();
        }

        public bool Delete(Entities.User.User user)
        {
            _userRepository.Delete(user);
            return _userRepository.SaveChanges();
        }

        public Entities.User.User FindByEmail(string email)
            => _userRepository.FindByEmail(email);

        public Entities.User.User FindByEmailPassword(string email, string password)
            => _userRepository.FindByEmailPassword(email, password);
    }
}
