
namespace ApiPractice.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void Save(Entities.User.User user);

        void Update(Entities.User.User user);

        void Delete(Entities.User.User user);

        Entities.User.User FindById(long id);
    }
}
