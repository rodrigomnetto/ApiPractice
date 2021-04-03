using ApiPractice.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiPractice.DbContexts
{
    public class ApiPracticeDbContext : DbContext
    {
        public ApiPracticeDbContext(DbContextOptions<ApiPracticeDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
    }
}
