namespace ApiPractice.Services.Interfaces
{
    public interface IUserService
    {
        bool Create(Entities.User.User user);

        bool Update(long id, Entities.User.User user);

        bool Delete(long id);

        Entities.User.User FindById(long id);

        Entities.User.User FindByEmailPassword(string email, string password);
    }
}
