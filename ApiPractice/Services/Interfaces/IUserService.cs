namespace ApiPractice.Services.Interfaces
{
    public interface IUserService
    {
        bool Create(Entities.User.User user);

        bool Update(Entities.User.User user, Entities.User.User updateUser);

        bool Delete(Entities.User.User user);

        Entities.User.User FindByEmail(string email);

        Entities.User.User FindByEmailPassword(string email, string password);
    }
}
