using ApiPractice.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace ApiPractice.Contexts
{
    public class ApiPracticeDbContext : DbContext
    {
        public ApiPracticeDbContext(DbContextOptions<ApiPracticeDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
    }
}
