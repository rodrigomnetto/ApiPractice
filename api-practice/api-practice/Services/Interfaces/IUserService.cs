namespace ApiPractice.Services.Interfaces
{
    public interface IUserService
    {
        void Save(Entities.User.User user);

        void Update(long id, Entities.User.User user);

        void Delete(long id);

        Entities.User.User FindById(long id);
    }
}
