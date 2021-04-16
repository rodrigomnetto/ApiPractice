namespace ApiPractice.Identity.Services.Interfaces
{
    public interface IAuthenticationService
    {
        string GenerateToken(Entities.User.User user);
    }
}
